USE [CyberIndigoAssignment]
GO

/****** Object:  Table [dbo].[Blog]    Script Date: 18-Oct-20 3:42:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Blog](
	[Identifier] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[SubTitle] [nvarchar](500) NULL,
	[ArticleDescription] [nvarchar](max) NULL,
	[TagId] [int] NULL,
	[OwnerEmailID] [nvarchar](500) NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

