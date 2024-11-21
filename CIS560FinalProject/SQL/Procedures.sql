DROP PROCEDURE IF EXISTS TryLogin;
DROP PROCEDURE IF EXISTS GetCharacter;
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
	CS.ClassID, CS.SubclassID, C.CharacterID
FROM Accounts A
	INNER JOIN [Character] C ON A.AccountID = C.AccountID
	INNER JOIN CharacterSubclass CS ON C.CharacterID = CS.CharacterID
WHERE A.UserName = @Username AND A.[Password] = @Password;
GO

CREATE PROCEDURE GetTalentsForCharacter @CharacterID INT
AS
SELECT CT.CharacterTalentID,
	CT.CharacterSubclassID,
	CT.Amount,
	T.TalentName,
	T.TalentDescription,
	T.TalentRank,
	T.TalentType
FROM CharacterSubclass CS
	INNER JOIN CharacterTalent CT ON CS.CharacterID = @CharacterID
		AND CS.CharacterSubclassID = CT.CharacterSubclassID
	INNER JOIN SubclassTalent ST ON CT.SubclassTalentID = ST.SubclassTalentID
	INNER JOIN Talent T ON ST.TalentID = T.TalentID
ORDER BY T.[Rank] DESC, T.[TalentType] ASC, T.[Name] DESC;
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
	INNER JOIN SubclassTalent ST ON S.SubclassID = ST.SubclassID
	INNER JOIN Talent T ON ST.TalentID = T.TalentID
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
	INNER JOIN SubclassTalent ST ON S.SubclassID = ST.SubclassID
	INNER JOIN Talent T ON ST.TalentID = T.TalentID
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
	INNER JOIN SubclassTalent ST ON S.SubclassID = ST.SubclassID
		AND S.SubclassName = @SubclassName
	INNER JOIN Talent T ON ST.TalentID = T.TalentID
ORDER BY S.SubclassName DESC, T.TalentType ASC, T.TalentName DESC, T.TalentRank ASC;
GO