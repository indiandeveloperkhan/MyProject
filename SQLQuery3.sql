CREATE PROC Login_Page
@UserName VARCHAR (50),
@Password  VARCHAR (50),
@Isvalid Bit OUt
AS
BEGIN
SET @Isvalid = (SELECT COUNT(1) FROM dbo.Login WHERE UserName = @UserName AND Password = @Password)

END

select * from dbo.Login;