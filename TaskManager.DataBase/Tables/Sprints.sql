CREATE TABLE [dbo].[sprints]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Description] NVARCHAR(150) NOT NULL, 
    [ProjectID] INT NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [Duration] INT NOT NULL,

	CONSTRAINT [FK_Sprints_Projects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[development_projects] ([ID]),
)
