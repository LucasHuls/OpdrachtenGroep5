SELECT * FROM dbo.tblEvent
WHERE CategoryID != 14 AND Details like '%Train%'
ORDER BY CategoryID

SELECT * FROM dbo.tblEvent
WHERE CountryID = 13 AND What NOT LIKE '%Space%' AND Details NOT LIKE '%Space%'

SELECT * FROM dbo.tblEvent
WHERE CategoryID IN (5,6) AND Details NOT LIKE '%War%' AND Details NOT LIKE '%Death%'