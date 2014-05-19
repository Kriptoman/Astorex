CREATE PROCEDURE [dbo].[get_work_items_by_dev]
    @UserName nvarchar(150)
AS

DECLARE @UserId int

SET @UserId = (SELECT [ID] 
FROM [dbo].[astorex_users]
WHERE @UserName = Username)

SELECT
    w.[ID],
    w.[Type],
    w.[Title],
    ws.[Title] as [State],
    w.[Effort]
FROM [dbo].[work_items] as w
	LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
	WHERE @UserId = AssignedTo
