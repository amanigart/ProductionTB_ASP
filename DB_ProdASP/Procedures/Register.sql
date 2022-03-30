CREATE PROCEDURE [dbo].[Register]
	@email NVARCHAR(100),
	@password NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @secretKey NVARCHAR(200)
	SET @secretKey = dbo.GetSecretKey()

	DECLARE @salt NVARCHAR(100)
	SET @salt = CONCAT(NEWID(), NEWID(), NEWID())
	
	DECLARE @passwordHash VARBINARY(64)
	SET @passwordHash = HASHBYTES('SHA2_512', CONCAT(@salt, @secretKey, @password, @salt))

	INSERT INTO dbo.[User] ([login], passwd, salt)
	OUTPUT Inserted.id_user
	VALUES (@email, @passwordHash, @salt)
END