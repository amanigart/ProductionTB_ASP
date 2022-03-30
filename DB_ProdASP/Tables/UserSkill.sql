CREATE TABLE [dbo].[UserSkill]
(
	[id_user] INT NOT NULL,
	[id_skill] INT NOT NULL,
	CONSTRAINT pf_userskill PRIMARY KEY (id_user, id_skill),
	CONSTRAINT fk_userskill_user FOREIGN KEY (id_user) REFERENCES dbo.[User](id_user),
	CONSTRAINT fk_userskill_skill FOREIGN KEY (id_skill) REFERENCES dbo.Skill(id_skill)
)
