DROP VIEW IF EXISTS ShowSubclassPopularity;
DROP VIEW IF EXISTS MostChosenTalentsBySubclass;
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
GRANT ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
GRANT SELECT ON VIEW::ShowSubclassPopularity TO PUBLIC;
GO

CREATE VIEW MostChosenTalentsBySubclass
AS
SELECT S.Name, COUNT(CT.TalentID) AS NumberOfTalent
FROM Subclass S 
    INNER JOIN Talent T ON S.SubclassID = T.SubclassID
    INNER JOIN CharacterTalent CT ON T.TalentID = CT.TalentID
GROUP BY S.ClassID, ST.TalentID
ORDER BY COUNT(CT.TalentID) DESC;
GO

-- Managing permissions for MostChosenTalentsBySubclass
--DENY ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GRANT ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
--GRANT SELECT ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GO