CREATE PROCEDURE [dbo].[Login]
	@login NVARCHAR(100),
	@password NVARCHAR(50)
AS
BEGIN
	DECLARE @secretKey NVARCHAR(200)
	SET @secretKey = dbo.GetSecretKey()

	DECLARE @salt NVARCHAR(100)
	SET @salt = (SELECT salt FROM dbo.[User] WHERE [login] = @login)

	DECLARE @passwordHash VARBINARY(64)
	SET @passwordHash = HASHBYTES('SHA2_512', CONCAT(@salt, @secretKey, @password, @salt))

	SELECT id_user, [login], passwd 
	FROM dbo.[User] 
	WHERE [login] = @login AND passwd = @passwordHash
END
