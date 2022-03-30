-- Disable skill instead of delete
CREATE PROCEDURE [dbo].[DeleteSkill]
	@id INT
AS
BEGIN
	DELETE FROM Skill
	WHERE id_skill = @id
END
