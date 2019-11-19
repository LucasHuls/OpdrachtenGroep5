USE [WorldEvents]
GO

/****** Object:  Table [dbo].[tblEvent]    Script Date: 4-11-2019 09:48:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEvent](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [varchar](8000) NULL,
	[EventDetails] [varchar](max) NULL,
	[EventDate] [date] NULL,
	[CountryID] [int] NULL,
	[CategoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblEvent]  WITH CHECK ADD  CONSTRAINT [FK_tblEvent_tblCategory1] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategory] ([CategoryID])
GO

ALTER TABLE [dbo].[tblEvent] CHECK CONSTRAINT [FK_tblEvent_tblCategory1]
GO

ALTER TABLE [dbo].[tblEvent]  WITH CHECK ADD  CONSTRAINT [FK_tblEvent_tblCountry] FOREIGN KEY([CountryID])
REFERENCES [dbo].[tblCountry] ([CountryID])
GO

ALTER TABLE [dbo].[tblEvent] CHECK CONSTRAINT [FK_tblEvent_tblCountry]
GO

