CREATE PROCEDURE [dbo].[DeletePersonalInfo]
	@id INT
AS
BEGIN
	DELETE FROM Personal_Info
	WHERE id_info = @id
END
