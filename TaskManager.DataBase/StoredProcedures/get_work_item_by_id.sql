CREATE PROCEDURE [dbo].[get_work_item_by_id]
    @ID int
AS

    SELECT 
	w.[ID],
	w.[BacklogPriority],
	w.[DateEnded],
	w.[DateStarted],
	w.[Description],
	w.[Effort],
	w.[Reason],
	w.[Title],
	wt.[Type],
	s.[Title] as [Sprint],
	dev.[FirstName] + dev.[LastName] as [Developer]
	FROM [dbo].work_items as w
    LEFT JOIN [dbo].work_items_states as s on s.ID = w.StateID
	LEFT JOIN [dbo].team_description as dev on dev.UserID = w.AssignedTo
	LEFT JOIN [dbo].work_item_types as wt on wt.ID = w.TypeId
    WHERE w.[ID] = @ID
