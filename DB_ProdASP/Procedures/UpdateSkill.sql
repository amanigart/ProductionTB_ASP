CREATE PROCEDURE [dbo].[UpdateSkill]
	@name NVARCHAR(50),
	@icon NVARCHAR(100),
	@id INT
AS
BEGIN
	UPDATE Skill
	SET [name] = @name,
		icon = @icon
	WHERE id_skill = @id
END
