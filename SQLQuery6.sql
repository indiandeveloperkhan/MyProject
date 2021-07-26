CREATE PROC Batch_Updation
@Domain_Id VARCHAR (50),
@Faculty_Id VARCHAR (50),
@Batch_Start_Date DATE ,
@Batch_End_Date DATE
AS
BEGIN
Update dbo.[Batch Allocation]
SET
Domain_Id = @Domain_Id,
Faculty_Id = @Faculty_Id,
Batch_Start_Date = @Batch_Start_Date,
Batch_End_Date = @Batch_End_Date
WHERE Faculty_Id=@Faculty_Id
END