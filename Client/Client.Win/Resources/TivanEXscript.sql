
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[faults](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NOT NULL,
	[ModeId] [int] NOT NULL,
	[NominalId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Value] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Model]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Model](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Code] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Nominal]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Nominal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModelId] [int] NOT NULL,
	[Key] [nvarchar](100) NOT NULL,
	[Titel] [nvarchar](200) NOT NULL,
	[Tel+] [float] NULL,
	[Tel-] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[NominalValue]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[NominalValue](
	[TypeId] [int] NOT NULL,
	[NominalId] [int] NOT NULL,
	[Value] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Total]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Total](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NOT NULL,
	[ModeId] [int] NOT NULL,
	[OnDate] [datetime] NOT NULL,
	[OffDate] [datetime] NOT NULL,
	[Sum] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Type]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentTypeId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Type_Units]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Type_Units](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[DESCRIPTION] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [TivanEX].[dbo].[Users]    Script Date: 2/19/2023 12:44:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TivanEX].[dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](200) NOT NULL,
	[Date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [TivanEX].[dbo].[faults]  WITH CHECK ADD FOREIGN KEY([ModeId])
REFERENCES [TivanEX].[dbo].[Model] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[faults]  WITH CHECK ADD FOREIGN KEY([NominalId])
REFERENCES [TivanEX].[dbo].[Nominal] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[faults]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [TivanEX].[dbo].[Type] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[Model]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [TivanEX].[dbo].[Type] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[Nominal]  WITH CHECK ADD FOREIGN KEY([ModelId])
REFERENCES [TivanEX].[dbo].[Model] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[NominalValue]  WITH CHECK ADD FOREIGN KEY([NominalId])
REFERENCES [TivanEX].[dbo].[Nominal] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[NominalValue]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [TivanEX].[dbo].[Type] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[Total]  WITH CHECK ADD FOREIGN KEY([ModeId])
REFERENCES [TivanEX].[dbo].[Model] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[Total]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [TivanEX].[dbo].[Type] ([Id])
GO
ALTER TABLE [TivanEX].[dbo].[Type]  WITH CHECK ADD FOREIGN KEY([ParentTypeId])
REFERENCES [TivanEX].[dbo].[Type] ([Id])
GO