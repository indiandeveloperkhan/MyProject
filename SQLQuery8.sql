CREATE PROC Fact_display
@Faculty_Id VARCHAR (50)
AS
BEGIN
SELECT * FROM DBO.ReportSubmission WHERE Faculty_Id=@Faculty_Id
END