CREATE PROCEDURE [dbo].[UpdateExperience]
	@start INT,
	@end INT,
	@employer NVARCHAR(50),
	@job NVARCHAR(50),
	@id INT
AS
BEGIN
	UPDATE Experience
	SET date_start = @start,
		date_end = @end,
		employer = @employer,
		job_function = @job
	WHERE id_experience = @id
END
