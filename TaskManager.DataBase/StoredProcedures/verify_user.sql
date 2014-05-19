CREATE PROCEDURE [dbo].[verify_user]
	@Username nvarchar(50),
	@Password nvarchar(50)
AS
	SELECT [Username] FROM [dbo].astorex_users
	WHERE [Username] = @Username AND [Password] = @Password
