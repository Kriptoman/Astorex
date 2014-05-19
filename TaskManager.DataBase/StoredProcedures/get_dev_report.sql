CREATE PROCEDURE [dbo].[get_dev_report]
@DevelorepId int
AS
    CREATE TABLE #result (
	[ID]					int,
    [Post]					nvarchar(50),
    [FirstName]				nvarchar(50),
    [LastName]				nvarchar(50),
    [Department]			nvarchar(50)
)

INSERT INTO #result([ID], [FirstName], [LastName], [Post], [Department])
SELECT
    t.[ID],
    t.[FirstName],
    t.[LastName],
    p.[Name] as [Post],
    d.[Name] as [Department]
FROM [dbo].[team_description] as t
	LEFT JOIN [dbo].[posts] as p ON t.PostID = p.ID
	LEFT JOIN [dbo].[departments] as d ON t.DepartmentID = d.ID
WHERE @DevelorepId = t.[ID]

SELECT * FROM #result
