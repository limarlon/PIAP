USE [PIAP]
GO

/****** 对象: Table [dbo].[Direction] 脚本日期: 2014/5/22 14:38:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Direction];


GO
CREATE TABLE [dbo].[Direction] (
    [Id]      NVARCHAR (50) NOT NULL,
    [Code]    NVARCHAR (50) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Remarks] NVARCHAR (50) NULL,
    [Enable]  BIT           NOT NULL,
    [Deleted] BIT           NOT NULL
);


