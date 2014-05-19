CREATE TABLE [dbo].[team_description]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DepartmentID] INT NOT NULL, 
    [PostID] INT NOT NULL,
    [UserID] INT NOT NULL

    CONSTRAINT [FK_Description_Post] FOREIGN KEY ([PostID]) REFERENCES [dbo].[posts] ([ID]),
    CONSTRAINT [FK_Description_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[departments] ([ID]),
    CONSTRAINT [FK_Description_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[astorex_users] ([ID]),
)
