CREATE TABLE [dbo].[work_items]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Title] NVARCHAR(150) NOT NULL, 
    [Type] NVARCHAR(20) NOT NULL, 
    [StateID] int NOT NULL, 
    [Effort] FLOAT NULL, 
    [AssignedTo] INT NOT NULL, 
    [Reason] NVARCHAR(150) NOT NULL, 
    [BacklogPriority] INT NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DateStarted] DATETIME NOT NULL, 
    [DateEnded] DATETIME NULL,
    [SprintID] INT NOT NULL, 

    CONSTRAINT [FK_WorkItems_Sprint] FOREIGN KEY ([SprintID]) REFERENCES [dbo].[sprints] ([ID]),
    CONSTRAINT [FK_WorkItems_States] FOREIGN KEY ([StateID]) REFERENCES [dbo].[work_items_states] ([ID]),
    CONSTRAINT [FK_WorkItems_AssignedTo] FOREIGN KEY ([AssignedTo]) REFERENCES [dbo].[astorex_users] ([ID]),
)
