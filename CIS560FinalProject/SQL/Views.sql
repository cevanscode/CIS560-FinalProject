DROP VIEW IF EXISTS ShowSubclassPopularity;
DROP VIEW IF EXISTS MostChosenTalentsBySubclass;
DROP VIEW IF EXISTS TalentRankingsByClass;
GO

CREATE VIEW SubclassPopularity
AS
SELECT S.Name, COUNT(CS.SubclassID) AS SubclassCount
FROM CharacterSubclass CS INNER JOIN
    Subclass S ON S.SubclassID = CS.SubclassID
ORDER BY COUNT(CS.SubclassID) DESC;
GO

-- Managing permissions for SubclassPopularity
--DENY ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
--GRANT ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
--GRANT SELECT ON VIEW::ShowSubclassPopularity TO PUBLIC;
GO

CREATE VIEW MostChosenTalentsBySubclass
AS
SELECT S.Name, COUNT(CT.TalentID) AS NumberOfTalent
FROM Subclass S 
    INNER JOIN Talent T ON S.SubclassID = T.SubclassID
    INNER JOIN CharacterTalent CT ON T.TalentID = CT.TalentID
GROUP BY S.ClassID, T.TalentID
ORDER BY COUNT(CT.TalentID) DESC;
GO

-- Managing permissions for MostChosenTalentsBySubclass
--DENY ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
--GRANT ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
--GRANT SELECT ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GO

/*
CREATE VIEW TalentRankingsByClass
AS
WITH ClassNameCTE(ClassName, ClassID)
AS
    (
        SELECT C.ClassName, C.ClassID FROM Class C
    )
SELECT C.ClassName
FROM Talent T
    INNER JOIN CharacterTalent CT ON T.TalentID = CT.CharacterTalentID
    INNER JOIN ClassNameCTE C ON  T.ClassID = C.ClassID
    INNER JOIN
GROUP BY CS.CharacterID, C.ClassName
GO
*/


