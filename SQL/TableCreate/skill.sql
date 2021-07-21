USE [WorkoutHunter]
GO

/****** Object:  Table [dbo].[skill]    Script Date: 2021/7/20 下午 12:05:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[skill](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](10) NULL,
	[SkillDamage] [int] NULL,
	[CD] [int] NULL,
	[SkillPic] [nvarchar](10) NULL,
 CONSTRAINT [PK_skill] PRIMARY KEY CLUSTERED
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [SN_Unique] UNIQUE NONCLUSTERED
(
	[SkillName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


