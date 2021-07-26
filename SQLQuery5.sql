CREATE PROC Batch_Allocation
@Domain_Id VARCHAR (50),
@Faculty_Id VARCHAR (50),
@Batch_Start_Date DATE ,
@Batch_End_Date DATE
AS
BEGIN
INSERT INTO DBO.[Batch Allocation]
(
Domain_Id ,
Faculty_Id,
Batch_Start_Date,
Batch_End_Date
)
VALUES
(
@Domain_Id,
@Faculty_Id ,
@Batch_Start_Date,
@Batch_End_Date
)
END