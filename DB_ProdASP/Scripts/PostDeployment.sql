/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

EXEC Register 'adm', 'Test1234'

INSERT INTO Skill ([name], icon)
VALUES ('C#', 'devicon-csharp-plain'),
       ('.NET', 'devicon-dot-net-plain'),
       ('.NET Core', 'devicon-dotnetcore-plain'),
       ('Azure', 'devicon-azure-plain'),
       ('HTML', 'devicon-html5-plain'),
       ('CSS', 'devicon-css3-plain'),
       ('Javascript', 'devicon-javascript-plain'),
       ('Angular', 'devicon-angularjs-plain'),
       ('Node.js', 'devicon-nodejs-plain'),
       ('SQL-Server', 'devicon-microsoftsqlserver-plain'),
       ('Git', 'devicon-git-plain'),
       ('GitHub', 'devicon-github-plain'),
       ('Trello', 'devicon-trello-plain'),
       ('Jira', 'devicon-jira-plain')

EXEC SaveExperience 2007, 2008, 'CHR de Namur', 'Service lingerie'
EXEC SaveExperience 2010, 2010, 'TechnofuturTIC', 'Formation : Promotion de sites Web (SEO)'
EXEC SaveExperience 2011, 2014, 'EasyPronostic', 'Création & gestion de site web (Wordpress) et forum (phpBB), +1800 membres'
EXEC SaveExperience 2015, 2016, 'Pause', 'Sandwicherie - Accueil, service, préparations'
EXEC SaveExperience 2016, 2018, 'Chat & Chew', 'Snack - Accueil & service'

EXEC SavePersonalInfo 'Manigart', 'Adrien', 'ad.manigart@gmail.com', '0471/77.71.26', 'Place Chanoine Descamps', '14/6', 5000, 'Namur', 'B', NULL, 'Bachelier Marketing', 2009, 'Ecole Supérieure des Affaires de Namur', 'Analyst Developer .NET', 'Qualité 1', 'Qualité 2', 'Qualité 3', 'Faiblesse 1', 'Faiblesse 2', 'Faiblesse 3', 'amanigart@github.com', 'adManigart#1363';
