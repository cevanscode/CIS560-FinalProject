DROP VIEW IF EXISTS ShowSubclassPopularity;
GO

CREATE VIEW ShowSubclassPopularity
AS
SELECT S.Name, COUNT(CS.SubclassID) AS SubclassCount
FROM CharacterSubclass CS INNER JOIN
    Subclass S ON S.SubclassID = CS.SubclassID
ORDER BY COUNT(CS.SubclassID) DESC;
GO

GRANT SELECT ON VIEW::ShowSubclassPopularity TO PUBLIC;
GO