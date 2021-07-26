CREATE PROC Module_Registration
@Technology_Name VARCHAR (50),
@Domain_Description VARCHAR (50),
@Module_Type VARCHAR(50),
@Duration VARCHAR (50)
AS
BEGIN
INSERT INTO DBO.[Module Registration Screen]
(
Technology_Name,
Domain_Description,
Module_Type,
Duration
)
VALUES
(
@Technology_Name,
@Domain_Description ,
@Module_Type,
@Duration

)
END
