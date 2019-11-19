SELECT *
FROM dbo.tblEvent
EXEC sp_rename 'dbo.tblEvent.EventDetails', 'Details', 'COLUMN'
EXEC sp_rename 'dbo.tblEvent.EventName', 'What', 'COLUMN'