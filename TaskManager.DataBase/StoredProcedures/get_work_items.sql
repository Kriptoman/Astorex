CREATE PROCEDURE [dbo].[get_work_items]
    @StartDate datetime,
    @Period int
AS
    SELECT * FROM [dbo].work_items
    LEFT JOIN [dbo].work_items_states on work_items_states.Id = work_items.StateID
    WHERE [DateStarted] >= @StartDate AND [DateStarted] <= @StartDate + DATEADD(day, @Period * 7, @StartDate)

