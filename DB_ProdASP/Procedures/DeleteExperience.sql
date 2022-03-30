CREATE PROCEDURE [dbo].[DeleteExperience]
	@id INT
AS
BEGIN
	DELETE FROM Experience
	WHERE id_experience = @id
END
