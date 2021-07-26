CREATE PROC Report_Submission
@Batch_Code VARCHAR (50),
@Faculty_Id  VARCHAR (50),
@Submitted_Weekly_Reports  INT,
@Mock_Tests_Conducted INT,
@BHS_Report_Submitted VARCHAR (50),
@Innovation_Project_Titile VARCHAR (50),
@Innovation_Project_Description VARCHAR (50),
@Project_Status VARCHAR (50)
AS
BEGIN
INSERT INTO DBO.ReportSubmission
(
Batch_Code ,
Faculty_Id ,
Submitted_Weekly_Reports ,
Mock_Tests_Conducted,
BHS_Report_Submitted ,
Innovation_Project_Titile ,
Innovation_Project_Description,
Project_Status

)
VALUES
(
@Batch_Code,
@Faculty_Id ,
@Submitted_Weekly_Reports,
@Mock_Tests_Conducted,
@BHS_Report_Submitted,
@Innovation_Project_Titile,
@Innovation_Project_Description,
@Project_Status

)
END