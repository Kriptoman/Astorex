CREATE PROCEDURE [dbo].[create_sprint]
    @Description nvarchar(150), @ProjectId int,
	@StartDate datetime, @Duration int
AS
    INSERT INTO [dbo].[sprints] ([Description], [ProjectID], [StartDate], [Duration])
		VALUES (@Description, @ProjectId, @StartDate, @Duration)
