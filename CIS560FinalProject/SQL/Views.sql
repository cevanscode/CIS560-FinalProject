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
DENY ALL ON VIEW::ShowSubclassPopularity TO PUBLIC;
GRANT SELECT ON VIEW::ShowSubclassPopularity TO PUBLIC;
GO

CREATE VIEW MostChosenTalentsBySubclass
AS
SELECT S.Name,      --Should the ClassID be an enum? 
                    --I'm probably going to need to do a switch/
                    --case any time we want to print out
                    --the Class Names
        COUNT(CT.TalentID) AS NumberOfTalent
FROM Subclass S 
    INNER JOIN SubclassTalent ST ON S.SubclassID = ST.SubclassID
    INNER JOIN CharacterTalent CT ON ST.SubclassTalentID = CT.SubclassTalentID
GROUP BY S.ClassID, ST.TalentID
ORDER BY COUNT(CT.TalentID) DESC;
GO

-- Managing permissions for MostChosenTalentsBySubclass
DENY ALL ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GRANT SELECT ON VIEW::MostChosenTalentsBySubclass TO PUBLIC;
GO

/*
Current plan for controlling access to the Accounts table:
create a view that uses the querying person's username to
grab a single row from the Accounts table.
*/