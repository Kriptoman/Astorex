CREATE TABLE [dbo].[development_projects]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [StartedAt] DATETIME NOT NULL, 
    [LastChanges] DATETIME NOT NULL
)
