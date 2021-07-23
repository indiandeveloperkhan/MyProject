CREATE PROC Faculty_Information
@Faculty_Name VARCHAR (50),
@Highest_Qualification VARCHAR (50),
@Year_of_Experience VARCHAR(50),
@Contact VARCHAR (50),
@Faculty_Email VARCHAR (50),
@Address VARCHAR (50)
AS
BEGIN
INSERT INTO DBO.Faculty_Person_Information
(
Faculty_Name,
Highest_Qualification,
Year_of_Experience,
Contact,
Faculty_Email,
Address
)
VALUES
(
@Faculty_Name,
@Highest_Qualification ,
@Year_of_Experience,
@Contact,
@Faculty_Email,
@Address
)
END
