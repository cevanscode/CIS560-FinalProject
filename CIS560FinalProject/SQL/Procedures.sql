DROP PROCEDURE IF EXISTS TryLogin;
DROP PROCEDURE IF EXISTS GetCharacter;
DROP PROCEDURE IF EXISTS GetCharacterID;
DROP PROCEDURE IF EXISTS GetTalentsForCharacter;
DROP PROCEDURE IF EXISTS GetClasses;
DROP PROCEDURE IF EXISTS GetSubclasses;
DROP PROCEDURE IF EXISTS GetTalents;
DROP PROCEDURE IF EXISTS GetTalentsForClass;
DROP PROCEDURE IF EXISTS GetTalentsForSubclass;
GO




CREATE PROCEDURE TryLogin @UserName NVarChar(30), @Password Binary(40)
AS
SELECT A.UserName, A.Email, FullName, Birthday
FROM Accounts A
	INNER JOIN [Character] C ON A.AccountID = C.AccountID
WHERE A.UserName = @Username AND A.[Password] = @Password;
GO


CREATE PROCEDURE GetCharacter @UserName NVarChar(30), @Password Binary(40)
AS
SELECT C.CharacterName, C.CharacterAge, C.Health, C.XP, C.Copper,
	CS.ClassID, CS.SubclassID
FROM Accounts A
	INNER JOIN [Character] C ON A.AccountID = C.AccountID
	INNER JOIN CharacterSubclass CS ON C.CharacterID = CS.CharacterID
WHERE A.UserName = @Username AND A.[Password] = @Password;
GO

CREATE PROCEDURE GetCharacterID @UserName NVarChar(30), @Password Binary(40)
AS
SELECT C.CharacterID
FROM [Character] C
	INNER JOIN Accounts A ON C.AccountID = A.AccountID
		AND A.UserName = @UserName AND A.[Password] = @Password;
GO

CREATE PROCEDURE GetTalentsForCharacter @CharacterID INT
AS
SELECT CT.CharacterTalentID,
	CT.CharacterSubclassID,
	CT.Amount,
	T.[Name],
	T.[Description],
	T.[Rank],
	T.[TalentType]
FROM CharacterSubclass CS
	INNER JOIN CharacterTalent CT ON CS.CharacterID = @CharacterID
		AND CS.CharacterSubclassID = CT.CharacterSubclassID
	INNER JOIN SubclassTalent ST ON CT.SubclassTalentID = ST.SubclassTalentID
	INNER JOIN Talent T ON ST.TalentID = T.TalentID
ORDER BY T.[Rank] DESC, T.[TalentType] ASC, T.[Name] DESC;
GO

CREATE PROCEDURE GetClasses
AS
SELECT *
FROM UNINITIALIZED
;
GO

CREATE PROCEDURE GetSubclasses
AS
SELECT *
FROM UNINITIALIZED
;
GO

CREATE PROCEDURE GetTalents
AS
SELECT *
FROM UNINITIALIZED
;
GO

CREATE PROCEDURE GetTalentsForClass @ClassID INT
AS
SELECT *
FROM UNINITIALIZED
;
GO

CREATE PROCEDURE GetTalentsForSubclass @SubclassID INT
AS
SELECT *
FROM UNINITIALIZED
;
GO