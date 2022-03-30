﻿CREATE TABLE [dbo].[User]
(
	[id_user] INT NOT NULL PRIMARY KEY IDENTITY,
	[login] NVARCHAR(50) NOT NULL UNIQUE,
	[passwd] VARBINARY(64) NOT NULL,
	[salt] NVARCHAR(200) NOT NULL
)