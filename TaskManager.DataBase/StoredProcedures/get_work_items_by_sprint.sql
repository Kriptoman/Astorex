CREATE PROCEDURE [dbo].[get_work_items_by_sprint]
    @SprintId int
AS

IF (@SprintId is NULL)
	BEGIN
		SELECT
			w.[ID],
			wt.[Type],
			w.[Title],
			ws.[Title] as [State],
			w.[Effort]
			FROM [dbo].[work_items] as w
				LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
				LEFT JOIN [dbo].[work_item_types] as wt ON wt.Id = w.TypeID
	END ELSE 
		BEGIN
			SELECT
			w.[ID],
			wt.[Type],
			w.[Title],
			ws.[Title] as [State],
			w.[Effort]
			FROM [dbo].[work_items] as w
				LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
				LEFT JOIN [dbo].[work_item_types] as wt ON wt.Id = w.TypeID
				WHERE @SprintId = SprintID
		END