CREATE PROCEDURE [dbo].[get_work_items_by_sprint]
    @SprintId int
AS

IF (@SprintId is NULL)
	BEGIN
		SELECT
			w.[ID],
			w.[Type],
			w.[Title],
			ws.[Title] as [State],
			w.[Effort]
			FROM [dbo].[work_items] as w
				LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
	END ELSE 
		BEGIN
			SELECT
			w.[ID],
			w.[Type],
			w.[Title],
			ws.[Title] as [State],
			w.[Effort]
			FROM [dbo].[work_items] as w
				LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
				WHERE @SprintId = SprintID
		END