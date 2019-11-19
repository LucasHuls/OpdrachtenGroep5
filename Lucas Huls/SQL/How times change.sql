USE [WorldEvents]

SELECT
    EventName AS [What],
    EventDate AS [When]
    FROM
        dbo.tblEvent
ORDER BY
    EventDate ASC

SELECT
    EventName AS [What]
    ,EventDate AS [When]
    FROM
        dbo.tblEvent
ORDER BY
    EventDate DESC