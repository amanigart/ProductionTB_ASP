﻿CREATE TABLE [dbo].[Personal_Info]
(
	[id_info] INT NOT NULL PRIMARY KEY IDENTITY,
	[lastname] NVARCHAR(50) NOT NULL,
	[firstname] NVARCHAR(50) NOT NULL,
	[email] NVARCHAR(100) NOT NULL,
	[phone] NVARCHAR(15) NOT NULL,
	[ad_street] NVARCHAR(100) NOT NULL,
	[ad_number] NVARCHAR(25) NOT NULL,
	[ad_zip] INT NOT NULL,
	[ad_city] NVARCHAR(50) NOT NULL,
	[driver_license] NVARCHAR(25),
	[recruiting_aid] NVARCHAR(50),
	[degree] NVARCHAR(100),
	[degree_date] INT,
	[degree_school] NVARCHAR(50),
	[profile] NVARCHAR(75) NOT NULL,
	[strength_1] NVARCHAR(50) NOT NULL,
	[strength_2] NVARCHAR(50) NOT NULL,
	[strength_3] NVARCHAR(50) NOT NULL,
	[weakness_1] NVARCHAR(50) NOT NULL,
	[weakness_2] NVARCHAR(50) NOT NULL,
	[weakness_3] NVARCHAR(50) NOT NULL,
	[github] NVARCHAR(50) NOT NULL,
	[discord] NVARCHAR(50) NOT NULL
)