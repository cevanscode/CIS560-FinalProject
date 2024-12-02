DROP VIEW IF EXISTS SubclassPopularity;
DROP VIEW IF EXISTS MostChosenTalents;
DROP VIEW IF EXISTS TalentRankingsByClass;
DROP PROCEDURE IF EXISTS GetSubclassPopularity;
DROP PROCEDURE IF EXISTS GetMostChosenTalentsBySubclass;
DROP PROCEDURE IF EXISTS TalentPopularity;
DROP PROCEDURE IF EXISTS AvgCopperBySubclass;
GO

CREATE VIEW SubclassPopularity
AS
SELECT S.SubclassName, COUNT(CS.SubclassID) AS SubclassCount
FROM CharacterSubclass CS INNER JOIN
    Subclass S ON S.SubclassID = CS.SubclassID
GROUP BY S.SubclassName
GO

CREATE PROCEDURE GetSubclassPopularity
AS
SELECT * FROM SubclassPopularity SP ORDER BY SubclassCount DESC;
GO

EXEC GetSubclassPopularity;

-- Managing permissions for SubclassPopularity
--DENY ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
--GRANT ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
--GRANT SELECT ON VIEW::ShowSubclassPopularity TO PUBLIC;
GO

CREATE VIEW MostChosenTalents
AS
SELECT S.SubclassName, COUNT(CT.TalentID) AS NumberOfTalent
FROM Subclass S 
    INNER JOIN Talent T ON S.SubclassID = T.SubclassID
    INNER JOIN CharacterTalent CT ON T.TalentID = CT.TalentID
GROUP BY S.SubclassName, T.TalentID
GO

CREATE PROCEDURE GetMostChosenTalentsBySubclass
AS
SELECT * FROM MostChosenTalents ORDER BY NumberOfTalent DESC;
GO

EXEC GetMostChosenTalentsBySubclass;
-- Managing permissions for MostChosenTalentsBySubclass
--DENY ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
--GRANT ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
--GRANT SELECT ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GO

CREATE PROCEDURE TalentPopularity
AS
SELECT 
    CharacterTalentCounts.SubclassID, 
    AVG(CharacterTalentCounts.TalentCount) AS AverageTalentCount
FROM 
    (SELECT 
        CS.CharacterID, 
        CS.SubclassID, 
        COUNT(CT.CharacterTalentID) AS TalentCount
     FROM CharacterTalent CT
      INNER JOIN CharacterSubclass CS ON CT.CharacterSubclassID = CS.CharacterSubclassID
     GROUP BY CS.CharacterID, CS.SubclassID) AS CharacterTalentCounts
GROUP BY CharacterTalentCounts.SubclassID;
GO

EXEC TalentPopularity;
GO

CREATE PROCEDURE AvgCopperBySubclass 
AS
SELECT RANK() OVER(ORDER BY AVG(CH.Copper) DESC) AS CopperRank, S.SubclassName, AVG(CH.Copper) AS AvgCopper
FROM [Character] CH
    INNER JOIN CharacterSubclass CS ON CH.CharacterID = CS.CharacterID
    INNER JOIN Subclass S ON CS.SubclassID = S.SubclassID
    INNER JOIN Class C ON S.ClassID = C.ClassID
GROUP BY S.SubclassName
ORDER BY AVG(CH.Copper) DESC, S.SubclassName ASC
GO

EXEC AvgCopperBySubclass;
GO


