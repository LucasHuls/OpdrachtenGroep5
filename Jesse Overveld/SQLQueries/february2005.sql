SELECT *
FROM dbo.tblEvent
WHERE dbo.tblEvent.EventDate BETWEEN Convert(datetime, '2005-02-01') AND Convert(datetime, '2005-02-28')