CREATE PROCEDURE [dbo].[UpdatePersonalInfo]
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
	UPDATE Personal_Info
	SET [lastname] = @name,
		firstname = @fName,
		email = @email,
		phone = @phone,
		ad_street = @street,
		ad_number = @number,
		ad_zip = @zip,
		ad_city = @city,
		driver_license = @driverLicense,
		recruiting_aid = @recruitingAid,
		degree = @degree,
		degree_date = @degreeDate,
		degree_school = @degreeSchool,
		[profile] = @profile,
		strength_1 = @strength1,
		strength_2 = @strength2,
		strength_3 = @strength3,
		weakness_1 = @weakness1,
		weakness_2 = @weakness2,
		weakness_3 = @weakness3,
		github = @github,
		discord = @discord
END

