CREATE PROCEDURE [dbo].[create_work_item]
    @Title nvarchar(150), @TypeId int,
	@StateID int, @SprintID int,
	@Reason nvarchar(150), @Effort int,
	@Description nvarchar(MAX), @BacklogPriority int,
	@DateStarted datetime, @DateEnded datetime = NULL,
    @AssignedTo int = NULL
AS
INSERT INTO [dbo].[work_items] ([Title], [TypeId], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
	   VALUES (@Title, @TypeId, @StateID, @SprintID, @Reason, @Effort, @Description, @DateStarted, @DateEnded, @BacklogPriority, @AssignedTo)
