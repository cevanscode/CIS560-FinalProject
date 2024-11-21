IF SCHEMA_Id(N'Larp') IS NULL
EXEC(N'CREATE SCHEMA [Larp];');
GO


DROP TABLE IF EXISTS CharacterTalent;
DROP TABLE IF EXISTS CharacterSubclass;
DROP TABLE IF EXISTS [Character];
DROP TABLE IF EXISTS Accounts;
DROP TABLE IF EXISTS SubclassTalent;
DROP TABLE IF EXISTS Talent;
DROP TABLE IF EXISTS Subclass;
DROP TABLE IF EXISTS Class;
GO

CREATE TABLE Accounts 
(
	AccountID INT NOT NULL PRIMARY KEY,
	UserName NVARCHAR(50) NOT NULL,
	AccountPassword VarBinary NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	FullName NVARCHAR(32) NOT NULL,
	Birthday DateTime2,
	-- LinkedAccountID INT FOREIGN KEY REFERENCES Accounts(AccountID)

	UNIQUE(UserName)
);
GO

CREATE TABLE [Character]
(
	CharacterID INT NOT NULL PRIMARY KEY,
	CharacterName NVARCHAR(32) NOT NULL,
	CharacterAge INT NOT NULL,
	AccountID INT NOT NULL FOREIGN KEY
		REFERENCES Accounts(AccountID),
	Health INT NOT NULL,
	XP INT NOT NULL,
	Copper INT NOT NULL

	UNIQUE(AccountID)
);
GO

CREATE TABLE CharacterSubclass 
(
	CharacterSubclassID INT NOT NULL PRIMARY KEY,
	CharacterID INT NOT NULL FOREIGN KEY
		REFERENCES [Character](CharacterID),
	ClassID INT NOT NULL,
	SubclassID INT NOT NULL
	
	FOREIGN KEY(ClassID, SubclassID) REFERENCES Subclass(ClassID, SubclassID)
	UNIQUE(SubclassID)
);
GO

CREATE TABLE Talent 
(
	TalentID INT NOT NULL PRIMARY KEY,
	TalentName NVARCHAR(30) NOT NULL,
	TalentDescription NVARCHAR(500),
	TalentRank INT NOT NULL, 
	TalentType INT NOT NULL

	UNIQUE(TalentName, TalentRank, TalentType)
);
GO

CREATE TABLE SubclassTalent
(
	SubclassTalentID INT NOT NULL PRIMARY KEY,
	TalentID INT NOT NULL FOREIGN KEY
		REFERENCES Talent(TalentID)

	UNIQUE(SubclassTalentName)
);
GO

CREATE TABLE CharacterTalent 
(
	SkillID INT NOT NULL PRIMARY KEY,
	CharacterSubclassID INT NOT NULL
		REFERENCES CharacterSubclass(CharacterSubclassID),
	SubclassTalentID INT NOT NULL FOREIGN KEY
		REFERENCES SubclassTalent(SubclassTalentID),
	Amount INT NOT NULL

	UNIQUE(CharacterSubclassID, SubclassTalentID)
	
);
GO

CREATE TABLE Class 
(
	ClassID INT NOT NULL PRIMARY KEY,
	ClassDescription NVARCHAR(500),
	ClassName NVARCHAR(30) NOT NULL

	UNIQUE(ClassName)
);
GO

CREATE TABLE Subclass 
(
	SubclassID INT NOT NULL PRIMARY KEY,
	ClassID INT NOT NULL FOREIGN KEY
		REFERENCES Class(ClassID),
	SubclassName NVARCHAR(30) NOT NULL

	UNIQUE(SubclassID, ClassID),
	UNIQUE(SubclassName)
);
GO