IF NOT EXISTS(select * from sys.databases where name = 'SpyerDb')
    CREATE DATABASE SpyerDb
GO

-----------------------------------------------------------------------------------------------------------------
USE [SpyerDb]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Captures](
	[Id] [uniqueidentifier] NOT NULL,
	[Bytes] [varbinary](max) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Captures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Captures] ADD  CONSTRAINT [DF_Captures_Id]  DEFAULT (newid()) FOR [Id]
GO
-----------------------------------------------------------------------------------------------------------------