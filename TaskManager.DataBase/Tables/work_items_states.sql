CREATE TABLE [dbo].[work_items_states]
(
    [ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Title] NVARCHAR(50) NOT NULL, 
    [Level] INT NOT NULL
)
