CREATE TABLE [dbo].[astorex_users]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [CreationDate] DATETIME NOT NULL, 
    [LastLoginDate] DATETIME NOT NULL, 
    [IsLockedOut] BIT NOT NULL, 
    [PailedPasswordAttemptCount] INT NOT NULL DEFAULT 3 
)


