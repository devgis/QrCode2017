USE [ms2703333]
GO

/****** Object:  Table [dbo].[T_FHCSIGN]    Script Date: 09/14/2017 09:29:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[T_FHCSIGN](
	[FHC] [int] NULL,
	[CUSTNO] [varchar](10) NULL,
	[SIGNTIME] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
