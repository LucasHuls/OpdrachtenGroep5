/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EventID]
      ,[EventName]
      ,[EventDetails]
      ,[EventDate]
      ,[CountryID]
      ,[CategoryID]
  FROM [dbo].[tblEvent]
  order by [EventDate] ASC 