CREATE TABLE [dbo].[Experience]
(
	[id_experience] INT NOT NULL PRIMARY KEY IDENTITY,
	[date_start] INT NOT NULL,
	[date_end] INT NOT NULL,
	[employer] NVARCHAR(50) NOT NULL,
	[job_function] NVARCHAR(50) NOT NULL,
)
