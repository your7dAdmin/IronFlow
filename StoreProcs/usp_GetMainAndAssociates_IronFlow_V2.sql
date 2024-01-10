/*
  EXAMPLE: 
      exec usp_GetMainAndAssociates_IronFlow 3669, NULL, 1,1
	  exec usp_GetMainAndAssociates_IronFlow 'NA-0129-23-101784', NULL, NULL, 1,1
	  exec usp_GetMainAndAssociates_IronFlow 3669
*/
CREATE OR ALTER PROC usp_GetMainAndAssociates_IronFlow
@appId INT = NULL,
@applicationId NVARCHAR(100) = NULL,
@isMain BIT = NULL,
@showAssociates BIT = NULL
AS
BEGIN

DECLARE @appAndAssociates TABLE (AppId INT, ApplicationId VARCHAR(50),AppStatusId INT, ItemMasterId INT, IsMain BIT, IsAssociates BIT);
IF((@appId = 0 OR @appId IS NULL) AND (@applicationId IS NOT NULL AND @applicationId <> ''))
 BEGIN
	SET @appId = (SELECT AppId FROM [Application] WHERE ApplicationId = @applicationId AND IsActive = 1);
 END

      IF ((@isMain IS NOT NULL AND @isMain = 1)OR (@isMain IS NULL AND @showAssociates IS NULL))
	    BEGIN
      --Main Application
   	    INSERT INTO @appAndAssociates (AppId, ApplicationId, AppStatusId, IsMain)
		SELECT A.AppId, A.ApplicationId, A.AppStatusId, CAST('TRUE' AS BIT) FROM [Application] A
		WHERE A.AppId = @appId;
		END

		 IF ((@showAssociates IS NOT NULL AND @showAssociates = 1) OR (@isMain IS NULL AND @showAssociates IS NULL))
		 BEGIN
		--Associates
		INSERT INTO @appAndAssociates (AppId, ApplicationId, AppStatusId, IsAssociates)
		SELECT 
			  ChildAppId,
			  A.ApplicationId,
			  A.AppStatusId,
			  CAST('TRUE' AS BIT)
			  FROM AppMapping AS C
			UNPIVOT (ChildAppId FOR ChildColumn IN (PermitAppId, AssoLicenseAppId, TempPermitAppId, TempAssociateLIcenseAppId, LiquidatorAppId, AmendmentAppId)) AS unpvt
			INNER JOIN [Application] A
			ON A.AppId = ChildAppId
			WHERE MainAppId = @appId
			ORDER BY AppMappingId
			, ChildColumn;
			END



	 --updating the result with masterID from wf
	 DECLARE @isDataInserted BIT = (SELECT COUNT(*) FROM @appAndAssociates);
	 IF(@isDataInserted = 1)
	    BEGIN
			UPDATE @appAndAssociates 
				SET ItemMasterId = V.ItemMasterId
				FROM vw_GetWorkFlowInfo V 
				INNER JOIN @appAndAssociates OBJ ON V.WfItemId = OBJ.AppId
				WHERE V.WfItemType = 'Application'
		END

    /*
	Scenarios:
	  1) when is main is true and associates false
	  2) when main false and associates true
	  3) when both are true (same as point 4)
	  4) when both are false (considering as null's and same if you select point 3)
	*/
	--return the decision
	SELECT 
	OBJ.ApplicationId, OBJ.AppId, OBJ.AppStatusId,
	W.WfItemMasterId, W.RoleId, W.TaskId, W.IsTimer, W.EndTime
	,W.TaskStatus, A.StatusDescription, IsMain, IsAssociates
	 FROM WfItemTaskMapping W
	INNER JOIN @appAndAssociates  OBJ ON W.WfItemMasterId = OBJ.ItemMasterId
	INNER JOIN ApplicationStatusRef A ON A.AppStatusId = OBJ.AppstatusId


END