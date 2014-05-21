CREATE PROCEDURE [dbo].[get_work_items_grid]
    @SprintID int = NULL,
	@UserID int = NULL
AS

SELECT
	w.[ID],
	wt.[Type],
	w.[Title],
	ws.[Title] as [State],
	w.[Effort]
	FROM [dbo].[work_items] as w
		LEFT JOIN [dbo].[work_items_states] as ws ON w.StateID = ws.ID
		LEFT JOIN [dbo].[work_item_types] as wt ON wt.Id = w.TypeID
		WHERE SprintID = CASE WHEN @SprintID IS NULL THEN SprintID ELSE @SprintID END
		AND AssignedTo = CASE WHEN @UserID IS NULL THEN AssignedTo ELSE @UserID END
