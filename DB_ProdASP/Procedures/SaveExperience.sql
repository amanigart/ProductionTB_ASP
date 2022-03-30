CREATE PROCEDURE [dbo].[SaveExperience]
	@start INT,
	@end INT,
	@employer NVARCHAR(50),
	@job NVARCHAR(50)
AS
BEGIN
	INSERT INTO Experience (date_start, date_end, employer, job_function)
	VALUES (@start, @end, @employer, @job);
END
