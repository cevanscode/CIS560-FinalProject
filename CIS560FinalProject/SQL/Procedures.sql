DROP PROCEDURE IF EXISTS TryLogin;
DROP PROCEDURE IF EXISTS GetCharacter;
DROP PROCEDURE IF EXISTS GetTalentsForCharacter;
DROP PROCEDURE IF EXISTS GetClasses;
DROP PROCEDURE IF EXISTS GetSubclasses;
DROP PROCEDURE IF EXISTS GetTalents;
DROP PROCEDURE IF EXISTS GetTalentsForClass;
DROP PROCEDURE IF EXISTS GetTalentsForSubclass;
DROP PROCEDURE IF EXISTS AdminGetAccounts;
DROP PROCEDURE IF EXISTS CreateAccount;
DROP PROCEDURE IF EXISTS AdminCreateClass;
DROP PROCEDURE IF EXISTS AdminCreateSubclass;
DROP PROCEDURE IF EXISTS MergeCharacterDetails;
DROP PROCEDURE IF EXISTS MergeCharacterTalent;
GO




CREATE PROCEDURE TryLogin @UserName NVarChar(50), @Password NVarChar(100)
AS
SELECT A.UserName, A.Email, A.FullName, A.Birthday
FROM Accounts A
	INNER JOIN [Character] C ON A.AccountID = C.AccountID
WHERE A.UserName = @Username AND A.AccountPassword = @Password;
GO




CREATE PROCEDURE GetCharacter @UserName NVarChar(50), @Password NVarChar(100)
AS
SELECT C.CharacterName, C.CharacterAge, C.Health, C.XP, C.Copper,
	C.ClassName, CS.SubclassName
FROM Accounts A
	INNER JOIN [Character] C ON A.AccountID = C.AccountID
	INNER JOIN CharacterSubclass CS ON C.CharacterID = CS.CharacterID
	INNER JOIN Class C ON C.ClassID = CS.ClassID
WHERE A.UserName = @Username AND A.AccountPassword = @Password;
GO




CREATE PROCEDURE GetTalentsForCharacter @UserName NVarChar(50), @Password NVarChar(100)
AS
SELECT CT.CharacterTalentID,
	CT.CharacterSubclassID,
	CT.Amount,
	T.TalentName,
	T.TalentDescription,
	T.TalentRank,
	T.TalentType
FROM CharacterSubclass CS
	INNER JOIN [Character] C ON C.CharacterName = @CharacterName
		AND C.CharacterID = CS.CharacterID
	INNER JOIN CharacterTalent CT ON CS.CharacterSubclassID = CT.CharacterSubclassID
	INNER JOIN Talent T ON CT.TalentID = T.TalentID
ORDER BY T.TalentRank DESC, T.TalentType ASC, T.TalentName DESC;
GO




CREATE PROCEDURE GetClasses
AS
SELECT C.ClassName, C.ClassDescription
FROM Class C
ORDER BY C.ClassName DESC;
GO




CREATE PROCEDURE GetSubclasses
AS
SELECT C.ClassName, S.SubclassName, S.SubclassDescription
FROM Class C
	INNER JOIN Subclass S ON C.ClassID = S.ClassID
ORDER BY C.ClassName DESC, S.SubclassName DESC;
GO




CREATE PROCEDURE GetTalents
AS
SELECT C.ClassName,
	S.SubclassName,
	T.TalentName,
	T.TalentDescription,
	T.TalentRank,
	T.TalentType
FROM Class C
	INNER JOIN Subclass S ON C.ClassID = S.ClassID
	INNER JOIN Talent T ON S.SubclassID = T.SubclassID
ORDER BY C.ClassName DESC, S.SubclassName DESC, T.TalentType ASC, T.TalentName DESC, T.TalentRank ASC;
GO




CREATE PROCEDURE GetTalentsForClass @ClassName NVarChar
AS
SELECT C.ClassName,
	S.SubclassName,
	T.TalentName,
	T.TalentDescription,
	T.TalentRank,
	T.TalentType
FROM Class C
	INNER JOIN Subclass S ON C.ClassID = S.ClassID
		AND C.ClassName = @ClassName
	INNER JOIN Talent T ON S.SubclassID = T.SubclassID
ORDER BY C.ClassName DESC, S.SubclassName DESC, T.TalentType ASC, T.TalentName DESC, T.TalentRank ASC;
GO




CREATE PROCEDURE GetTalentsForSubclass @SubclassName NVarChar
AS
SELECT C.ClassName,
	S.SubclassName,
	T.TalentName,
	T.TalentDescription,
	T.TalentRank,
	T.TalentType
FROM Subclass S
	INNER JOIN Talent T ON S.SubclassID = T.SubclassID
		AND S.SubclassName = @SubclassName
ORDER BY S.SubclassName DESC, T.TalentType ASC, T.TalentName DESC, T.TalentRank ASC;
GO




CREATE PROCEDURE AdminGetAccounts @UserName NVarChar(50), @Password NVarChar(100)
AS
IF @UserName = N'Admin' AND @Password = (SELECT AccountPassword FROM Accounts WHERE UserName = N'Admin')
BEGIN
	SELECT * FROM Accounts A ORDER BY A.AccountID ASC
END
GO




CREATE PROCEDURE CreateAccount @UserName NVarChar(50), @Password NVarChar(100), @Email NVARCHAR(50), @FullName NVARCHAR(32), @Birthday DateTime2
AS
INSERT Account(Username, AccountPassword, Email, FullName, Birthday)
VALUES(@UserName, @Password, @Email, @FullName, @Birthday);
GO




CREATE PROCEDURE AdminCreateClass @UserName NVarChar(50), @Password NVarChar(100), @ClassName NVarChar(30), @ClassDescription NVarChar(500)
AS
	INSERT Class(ClassName, ClassDescription)
	VALUES(@ClassName, @ClassDescription)
GO




CREATE PROCEDURE AdminCreateSubclass @UserName NVarChar(30), @Password NVarChar, @SubclassName NVarChar(30), @ClassName NVarChar(30), @SubclassDescription NVarChar(500)
AS
	INSERT Class(ClassID, SubclassDescription, SubclassName)
	VALUES((SELECT C.ClassID FROM Class C WHERE @ClassName = C.ClassName),@SubclassName, @SubclassDescription)
GO




CREATE PROCEDURE MergeCharacterDetails @UserName NVARCHAR(50),
	@Password NVarChar,
	@CharacterName NVARCHAR(32),
	@CharacterAge INT,
	@Health INT,
	@XP INT,
	@Copper INT
AS
WITH FindCharacter(CharacterID) AS
(
	SELECT C.CharacterID
	FROM Account A
		INNER JOIN [Character] C ON A.AccountID = C.AccountID
	WHERE A.UserName = @UserName AND A.AccountPassword = @Password
)
MERGE [Character] C
USING FindCharacter FC ON FC.CharacterID = C.CharacterID
WHEN MATCHED THEN
	UPDATE
	SET
		CharacterName = @CharacterName,
		CharacterAge = @CharacterAge,
		Health = @Health,
		XP = @XP,
		Copper = @Copper
WHEN NOT MATCHED AND FC.CharacterID IS NULL THEN
	INSERT(CharacterName, CharacterAge, Health, XP, Copper)
	VALUES(@CharacterName, @CharacterAge, @Health, @XP, @Copper);
GO




CREATE PROCEDURE MergeCharacterTalent @UserName NVARCHAR(50),
	@Password NVarChar,
	@TalentName NVarChar(30),
	@TalentRank INT,
	@TalentAmount INT
AS
WITH FindTalent(TalentID, CharacterSubclassID)
AS
(
	SELECT T.TalentID, CS.CharcterSubclassID
	FROM Accounts A
		INNER JOIN [Character] C ON A.UserName = @UserName
			AND A.AccountPassword = @Password
			AND A.AccountID = C.AccontID
		INNER JOIN CharacterSubclass CS ON C.CharacterID = CS.CharacterID
		INNER JOIN Subclass S ON CS.SubclassID = S.SubclassID
		INNER JOIN Talent T ON T.TalentName = @TalentName
			AND T.TalentRank = @TalentRank
			AND S.SubclassID = T.SubclassID
)
MERGE CharacterTalent CT
USING FindTalent FT ON CT.CharacterSubclassID = FT.CharacterSubclassID
	AND CT.TalentID = FT.TalentID
WHEN MATCHED THEN
	UPDATE
	SET
		Amount = @TalentAmount
WHEN NOT MATCHED THEN
	INSERT(CharacterSubclassID, TalentID, Amount)
	VALUES(FT.CharacterSubclassID, FT.TalentID, @TalentAmount);
GO