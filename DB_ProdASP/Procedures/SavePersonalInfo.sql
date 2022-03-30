CREATE PROCEDURE [dbo].[SavePersonalInfo]
	@name NVARCHAR(50),
	@fName NVARCHAR(50),
	@email NVARCHAR(100),
	@phone NVARCHAR(15),
	@street NVARCHAR(100),
	@number NVARCHAR(25),
	@zip INT,
	@city NVARCHAR(50),
	@driverLicense NVARCHAR(25),
	@recruitingAid NVARCHAR(50),
	@degree NVARCHAR(100),
	@degreeDate INT,
	@degreeSchool NVARCHAR(50),
	@profile NVARCHAR(75),
	@strength1 NVARCHAR(50),
	@strength2 NVARCHAR(50),
	@strength3 NVARCHAR(50),
	@weakness1 NVARCHAR(50),
	@weakness2 NVARCHAR(50),
	@weakness3 NVARCHAR(50),
	@github NVARCHAR(50),
	@discord NVARCHAR(50)
AS
BEGIN
	INSERT INTO Personal_Info (lastname, firstname, email, phone, ad_street, ad_number, ad_zip, ad_city, driver_license, recruiting_aid, degree, degree_date, degree_school, [profile], strength_1, strength_2, strength_3, weakness_1, weakness_2, weakness_3, github, discord)
	VALUES (@name, @fName, @email, @phone, @street, @number, @zip, @city, @driverLicense, @recruitingAid, @degree, @degreeDate, @degreeSchool, @profile, @strength1, @strength2, @strength3, @weakness1, @weakness2, @weakness3, @github, @discord);
END
