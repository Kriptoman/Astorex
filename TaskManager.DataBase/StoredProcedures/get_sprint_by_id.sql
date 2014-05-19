CREATE PROCEDURE [dbo].[get_sprint_by_id]
	@ID int
AS
    SELECT * FROM dbo.sprints WHERE ID = @ID
RETURN 0
