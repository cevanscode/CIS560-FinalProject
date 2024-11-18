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
	UserName NVARCHAR NOT NULL,
	[Password] NVARCHAR NOT NULL,
	Email NVARCHAR NOT NULL,
	FullName NVARCHAR(32) NOT NULL,
	Birthday DateTime2,
	-- LinkedAccountID INT FOREIGN KEY REFERENCES Accounts(AccountID)

	UNIQUE(UserName)
);
GO

CREATE TABLE [Character]
(
	CharacterID INT NOT NULL PRIMARY KEY,
	CharacterName NVARCHAR NOT NULL,
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
	SubclassID INT NOT NULL
	
	UNIQUE(SubclassID)
);
GO

CREATE TABLE Talent 
(
	TalentID INT NOT NULL PRIMARY KEY,
	TalentName NVARCHAR NOT NULL,
	TalentDescription NVARCHAR,
	[Rank] INT NOT NULL, 
	[TalentType] INT NOT NULL

	UNIQUE(TalentName, [Rank], TalentType)
);
GO

CREATE TABLE SubclassTalent 
(
	SubclassTalentID INT NOT NULL PRIMARY KEY,
	[Description] NVARCHAR,
	[Name] NVARCHAR,
	TalentID INT NOT NULL FOREIGN KEY
		REFERENCES Talent(TalentID)

	UNIQUE([Name])
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
	ClassDescription NVARCHAR,
	ClassName NVARCHAR NOT NULL

	UNIQUE(ClassName)
);
GO

CREATE TABLE Subclass 
(
	SubclassID INT NOT NULL PRIMARY KEY,
	ClassID INT NOT NULL FOREIGN KEY
		REFERENCES Class(ClassID),
	[Name] NVARCHAR NOT NULL

	UNIQUE(SubclassID, ClassID),
	UNIQUE(Name)
);
GO