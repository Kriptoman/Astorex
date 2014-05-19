CREATE PROCEDURE [dbo].[create_work_item]
    @Title nvarchar(150), @Type nvarchar(150),
	@StateID int, @SprintID int,
	@Reason nvarchar(150), @Effort int,
	@Description nvarchar(MAX), @BacklogPriority int,
	@DateStarted datetime, @DateEnded datetime = NULL,
    @AssignedTo int
AS
INSERT INTO [dbo].[work_items] ([Title], [Type], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
	   VALUES (@Title, @Type, @StateID, @SprintID, @Reason, @Effort, @Description, @DateStarted, @DateEnded, @BacklogPriority, @AssignedTo)
