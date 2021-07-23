CREATE PROC Faculty_Skill
@Faculty_Skill_1 VARCHAR (50),
@Faculty_Skill_2  VARCHAR (50),
@Faculty_Skill_3  VARCHAR(50),
@Certification_Titile VARCHAR (50)
AS
BEGIN
INSERT INTO DBO.[Faculty Skill And Certification]
(
Faculty_Skill_1 ,
Faculty_Skill_2 ,
Faculty_Skill_3 ,
Certification_Titile


)
VALUES
(
@Faculty_Skill_1,
@Faculty_Skill_2 ,
@Faculty_Skill_3,
@Certification_Titile

)
END