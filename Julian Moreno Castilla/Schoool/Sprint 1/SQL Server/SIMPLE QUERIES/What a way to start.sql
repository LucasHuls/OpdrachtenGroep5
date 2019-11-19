/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EventID]
      ,[EventName]
      ,[EventDetails]
      ,[EventDate]
      ,[CountryID]
      ,[CategoryID]
  FROM [WorldEvents].[dbo].[tblEvent]
  ORDER BY 
		[EventDate] DESC
 

		
		