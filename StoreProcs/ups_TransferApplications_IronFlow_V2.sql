/*
example: 
--DECLARE @dataTransfer VARCHAR(MAX)  = '{"AppId":222,"Isindividual":true,"IsAssociates":true,"isAll":false,"TaskId":1351,"TaskStatus":"Awaiting Review","AppStatusId":6,"WorkflowItemType":"Application","RoleId":3,"IsTimer":false,"EndTime":"test","isOnlyEndTime":false}'
*/
CREATE OR ALTER PROC ups_TransferApplications_IronFlow
@dataTransfer VARCHAR(MAX)
AS
BEGIN
 BEGIN TRY
--DECLARE @dataTransfer VARCHAR(MAX)  = '{"AppId":222,"Isindividual":true,"IsAssociates":true,"isAll":false,"TaskId":1351,"TaskStatus":"Awaiting Review","AppStatusId":6,"WorkflowItemType":"Application","RoleId":3,"IsTimer":false,"EndTime":"test","isOnlyEndTime":false}'
DECLARE @transferTable TABLE(AppId INT, IsIndividual BIT, IsAssociates BIT,  IsAll BIT, TaskId INT, TaskStatus VARCHAR(250), AppStatusId INT,
WorkflowItemType VARCHAR(250),  RoleId INT, IsTimer BIT, EndTime VARCHAR(250),  IsOnlyEndTime BIT, WfItemMasterId INT)

DECLARE @isTransferCompleted BIT = 0;



 INSERT INTO @transferTable
   SELECT TOP 1 T.*, WT.WfItemMasterId FROM OPENJSON(@dataTransfer)
   WITH(
      AppId INT '$.AppId',
	  IsIndividual BIT '$.Isindividual',
	  IsAssociates BIT '$.IsAssociates',
	  IsAll BIT '$.isAll',
	  TaskId INT '$.TaskId',
	  TaskStatus VARCHAR(250) '$.TaskStatus',
	  AppStatusId INT '$.AppStatusId',
	  WorkflowItemType VARCHAR(250) '$.WorkflowItemType',
	  RoleId INT '$.RoleId',
	  IsTimer BIT '$.IsTimer',
	  EndTime VARCHAR(250) '$.EndTime',
	  IsOnlyEndTime BIT '$.isOnlyEndTime'
   ) T
   INNER JOIN WfItemMaster  W ON W.WfItemId = T.AppId
   INNER JOIN WfItemTaskMapping WT ON WT.WfItemMasterId = W.Id 
   WHERE W.WfItemType = T.WorkflowItemType

 --  SELECT * FROM @transferTable


   --Update the values gotten
  IF EXISTS(SELECT COUNT(*) FROM @transferTable)
     BEGIN
	 MERGE INTO WfItemTaskMapping WT
	  USING @transferTable T
	  ON WT.WfItemMasterId = T.WfItemMasterId
	  WHEN MATCHED THEN
	     UPDATE
		   SET 
		     WT.TaskId = IIF(T.TaskId IS NULL OR T.TaskId = 0, WT.TaskId, T.TaskId),
			 WT.TaskStatus = IIF(T.TaskStatus IS NULL OR T.TaskStatus = '',WT.TaskStatus,T.TaskStatus),
			 WT.IsTimer = IIF(T.IsTimer IS NULL, WT.IsTimer, T.IsTimer),
			 WT.EndTime = IIF(T.EndTime IS NULL OR T.EndTime = '', WT.EndTime, T.EndTime),
			 WT.RoleId = IIF(T.RoleId IS NULL OR T.RoleId = 0, WT.RoleId, T.RoleId),
			 WT.ModifiedBy = 'System-External',
			 WT.ModifiedDate = GETDATE();

			 SET @isTransferCompleted = 1;
	 END

	 --After completed we are going to update the appStatusId
	  IF(@isTransferCompleted = 1)
	    BEGIN
		  UPDATE A
		   SET A.AppStatusId = CASE WHEN C.AppStatusId IS NULL OR C.AppStatusId = 0 THEN A.AppStatusId ELSE C.AppStatusId END, A.ModifiedBy = 'System-External', A.ModifiedDate = GETDATE()
		   FROM [Application] A
		   INNER JOIN @transferTable C ON A.AppId = C.AppId
		END

		SELECT 1 Id, @dataTransfer JsonText;  
    END TRY
	BEGIN CATCH
	 SELECT  
            ERROR_NUMBER() AS ErrorNumber  
            ,ERROR_SEVERITY() AS ErrorSeverity  
            ,ERROR_STATE() AS ErrorState  
            ,ERROR_PROCEDURE() AS ErrorProcedure  
            ,ERROR_LINE() AS ErrorLine  
            ,ERROR_MESSAGE() AS ErrorMessage;  
	END CATCH
END
