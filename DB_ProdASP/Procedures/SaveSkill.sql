CREATE PROCEDURE [dbo].[SaveSkill]
	@name NVARCHAR(50),
	@icon NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.Skill ([name], icon)
	VALUES (@name, @icon)
END
