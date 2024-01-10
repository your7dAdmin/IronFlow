CREATE PROC usp_GetWorkflowHistoryByAppId 
(
 @appId INT
)
AS
BEGIN
SELECT 
H.WfItemMasterId,
H.SourceTaskId,
H.SourceTaskStatus,
H.TargetTaskId,
H.TargetTaskStatus,
H.[Description],
H.IsActive,
H.CreatedBy,
H.CreatedDate
FROM WfItemMaster WF
INNER JOIN WfTaskFlowHistory H 
ON H.WfItemMasterId = (
SELECT TOP 1 WfItemMasterId FROM WfItemTaskMapping WT WHERE WF.Id = WT.WfItemMasterId)
WHERE WF.WfItemId = @appId;

END