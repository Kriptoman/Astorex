/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT ID FROM [astorex_users])
BEGIN
	SET IDENTITY_INSERT [astorex_users] ON
		INSERT INTO [dbo].[astorex_users] ([ID], [Username], [Password], [Email], [CreationDate], [LastLoginDate], [IsLockedOut], [PailedPasswordAttemptCount]) 
		VALUES (1, N'n.zastrelov', N'123456', N'zas.prog@gmail.com', '2013-12-26', '2013-12-26', 0, 3)
		INSERT INTO [dbo].[astorex_users] ([ID], [Username], [Password], [Email], [CreationDate], [LastLoginDate], [IsLockedOut], [PailedPasswordAttemptCount]) 
		VALUES (2, N'v.pupkin', N'123456789', N'pups@gmail.com', '2013-12-13', '2013-12-13', 0, 3)
		INSERT INTO [dbo].[astorex_users] ([ID], [Username], [Password], [Email], [CreationDate], [LastLoginDate], [IsLockedOut], [PailedPasswordAttemptCount]) 
		VALUES (3, N'a.vlasov', N'123456789', N'avlasa@gmail.com', '2013-12-13', '2013-12-13', 0, 3)
	SET IDENTITY_INSERT [astorex_users] OFF
END

IF NOT EXISTS (SELECT ID FROM [posts])
BEGIN
	SET IDENTITY_INSERT [posts] ON
		INSERT INTO [dbo].[posts] ([ID], [Name], [Description])
		VALUES (1, N'C# web developer', N'develops server part')
		INSERT INTO [dbo].[posts] ([ID], [Name], [Description])
		VALUES (2, N'makeup', N'develops layout and design')
        INSERT INTO [dbo].[posts] ([ID], [Name], [Description])
		VALUES (3, N'SQL developer', N'develops database part')
		INSERT INTO [dbo].[posts] ([ID], [Name], [Description])
		VALUES (4, N'QA', N'testing projects')
        INSERT INTO [dbo].[posts] ([ID], [Name], [Description])
		VALUES (5, N'PM', N'business workflow')
	SET IDENTITY_INSERT [posts] OFF
END

IF NOT EXISTS (SELECT ID FROM [departments])
BEGIN
	SET IDENTITY_INSERT [departments] ON
		INSERT INTO [dbo].[departments] ([ID], [Name], [Description])
		VALUES (1, N'Developers dep N1', N'develops small local projects')
		INSERT INTO [dbo].[departments] ([ID], [Name], [Description])
		VALUES (2, N'Developers dep N2', N'develops main projects')
	SET IDENTITY_INSERT [departments] OFF
END

IF NOT EXISTS (SELECT ID FROM [development_projects])
BEGIN
	SET IDENTITY_INSERT [development_projects] ON
		INSERT INTO [dbo].[development_projects] ([ID], [Name], [Description], [StartedAt], [LastChanges])
		VALUES (1, N'Astorex clouds OS', N'OS to manage cloud services', '2008-12-23', '2013-12-27')
		INSERT INTO [dbo].[development_projects] ([ID], [Name], [Description], [StartedAt], [LastChanges])
		VALUES (2, N'Task manager', N'local task manager for our company', '2013-12-24','2013-12-26')
	SET IDENTITY_INSERT [development_projects] OFF
END

IF NOT EXISTS (SELECT ID FROM [sprints])
BEGIN
	SET IDENTITY_INSERT [sprints] ON
		INSERT INTO [dbo].[sprints] ([ID], [Description], [ProjectID], [StartDate], [Duration])
		VALUES (1, N'Sprint 23/07', 1, '2013-12-01', 4)
		INSERT INTO [dbo].[sprints] ([ID], [Description], [ProjectID], [StartDate], [Duration])
		VALUES (2, N'Sprint 01/08', 2, '2013-12-24', 2)
		INSERT INTO [dbo].[sprints] ([ID], [Description], [ProjectID], [StartDate], [Duration])
		VALUES (3, N'Sprint 02/08', 2, '2014-02-13', 2)
	SET IDENTITY_INSERT [sprints] OFF
END

IF NOT EXISTS (SELECT ID FROM [work_items_states])
BEGIN
	SET IDENTITY_INSERT [work_items_states] ON
		INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (1, N'New', 1)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (2, N'Approved', 1)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (3, N'In progress', 2)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (4, N'Paused', 2)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (5, N'Done', 2)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (6, N'Ready for deploy', 3)
        INSERT INTO [dbo].[work_items_states] ([ID], [Title], [Level])
		VALUES (7, N'Not fixed', 3)
	SET IDENTITY_INSERT [work_items_states] OFF
END

IF NOT EXISTS (SELECT ID FROM [work_item_types])
BEGIN
		INSERT INTO [dbo].[work_item_types] ([ID], [Type])
		VALUES (1, N'Task')
        INSERT INTO [dbo].[work_item_types] ([ID], [Type])
		VALUES (2, N'Bug')
        INSERT INTO [dbo].[work_item_types] ([ID], [Type])
		VALUES (3, N'Testing')
END

IF NOT EXISTS (SELECT ID FROM [team_description])
BEGIN
	SET IDENTITY_INSERT [team_description] ON
		INSERT INTO [dbo].[team_description] ([ID], [FirstName], [LastName], [DepartmentID], [PostID], [UserID])
		VALUES (1, N'Nikita', N'Zastrelov', 2, 1, 1)
        INSERT INTO [dbo].[team_description] ([ID], [FirstName], [LastName], [DepartmentID], [PostID], [UserID])
		VALUES (2, N'Vasua', N'Pupkin', 2, 4, 2)
		INSERT INTO [dbo].[team_description] ([ID], [FirstName], [LastName], [DepartmentID], [PostID], [UserID])
		VALUES (3, N'Alex', N'Vlasov', 1, 2, 3)
	SET IDENTITY_INSERT [team_description] OFF
END

IF NOT EXISTS (SELECT ID FROM [work_items])
BEGIN
	SET IDENTITY_INSERT [work_items] ON
		INSERT INTO [dbo].[work_items] ([ID], [Title], [TypeId], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
		VALUES (1, N'Create login form', 1, 4, 2, N'Work paused', 8,  N'Требуется добавить страницу логина пользователя. На форме должны быть поля: пароль, имя пользователя, сохранения куков', '2013-12-25', NULL, 20, 1)
        INSERT INTO [dbo].[work_items] ([ID], [Title], [TypeId], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
		VALUES (2, N'Js error on home page', 2, 5, 1, N'Done', 8,  N'Смотри скрины: http://screencast.com/t/wsHCvhGVs1wr', '2013-12-22', '2013-12-22', 10, 2)
		INSERT INTO [dbo].[work_items] ([ID], [Title], [TypeId], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
		VALUES (3, N'Something going wrong on chart', 3, 4, 2, N'Something going wrong', 8,  N'test', '2013-12-25', NULL, 25, 3)
        INSERT INTO [dbo].[work_items] ([ID], [Title], [TypeId], [StateID], [SprintID], [Reason], [Effort], [Description], [DateStarted], [DateEnded], [BacklogPriority], [AssignedTo])
		VALUES (4, N'Crash workitems page', 2, 5, 3, N'Crash', 8,  N'test 1', '2014-02-03', '2013-02-04', 15, 2)
	SET IDENTITY_INSERT [work_items] OFF
END