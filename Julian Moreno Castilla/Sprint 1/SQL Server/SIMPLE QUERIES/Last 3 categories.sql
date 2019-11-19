/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CategoryID]
      ,[CategoryName]
  FROM [WorldEvents].[dbo].[tblCategory]
  ORDER BY [CategoryID] DESC
