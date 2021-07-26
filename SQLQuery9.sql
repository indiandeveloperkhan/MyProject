CREATE PROC Batch_Data
@Batch_ID VARCHAR (50),
@Feedback_Percentage INT,
@Extra_Hours INT,
@BatchPass_Percentage INT ,
@Faculty_Upgrade VARCHAR (50),
@Certification_Done VARCHAR (50),
@Handson_Completion_Percentage VARCHAR (50)
AS
BEGIN
INSERT INTO DBO.[Batch Screen]
(
Batch_ID ,
Feedback_Percentage,
Extra_Hours,
BatchPass_Percentage,
Faculty_Upgrade,
Certification_Done,
Handson_Completion_Percentage 
)
VALUES
(
@Batch_ID,
@Feedback_Percentage ,
@Extra_Hours,
@BatchPass_Percentage,
@Faculty_Upgrade,
@Certification_Done,
@Handson_Completion_Percentage 
)
END