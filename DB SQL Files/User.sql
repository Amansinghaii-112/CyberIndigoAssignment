USE [CyberIndigoAssignment]
GO

/****** Object:  Table [dbo].[User]    Script Date: 18-Oct-20 3:43:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Identifier] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](500) NULL,
	[UserPassword] [nvarchar](50) NULL,
	[UserEmailId] [nvarchar](500) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

