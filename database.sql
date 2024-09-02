USE [EmployeeRating]
GO
/****** Object:  Table [dbo].[RateCards]    Script Date: 02/09/2024 15:57:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RateCards](
	[Id] [uniqueidentifier] NULL,
	[Job] [varchar](50) NULL,
	[Dept] [varchar](50) NULL,
	[EffectiveStart] [date] NULL,
	[EffectiveEnd] [date] NULL,
	[HourlyRate] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeCards]    Script Date: 02/09/2024 15:57:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeCards](
	[Id] [uniqueidentifier] NOT NULL,
	[EmployeeName] [varchar](50) NULL,
	[EmployeeNumber] [varchar](50) NULL,
	[DateWorked] [date] NULL,
	[EarningsCode] [varchar](50) NULL,
	[JobWorked] [varchar](50) NULL,
	[DeptWorked] [varchar](50) NULL,
	[Hours] [decimal](18, 2) NULL,
	[Rate] [decimal](18, 2) NULL,
	[Bonus] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TimeCards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'2f9a3a68-f056-4e33-a8ba-d25a9b04bf6e', N'Laborer', N'001', CAST(N'2023-01-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(18.75 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'af9c85e8-5d63-4517-afe8-080e40348188', N'Laborer', N'002', CAST(N'2023-01-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(17.85 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'b9d53a8e-6b19-49c0-b974-fb2aa52a2fe7', N'Scrapper', N'001', CAST(N'2022-03-01' AS Date), CAST(N'2023-03-01' AS Date), CAST(19.45 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'b75a444f-7629-446a-86c9-820a27c67479', N'Scrapper', N'001', CAST(N'2023-04-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(20.45 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'bf7ae9be-d572-4a74-9094-552c275229ff', N'Scrapper', N'002', CAST(N'2022-03-01' AS Date), CAST(N'2023-03-01' AS Date), CAST(20.55 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'4073c716-13b9-41c2-90e9-344bed7b3c70', N'Scrapper', N'002', CAST(N'2023-04-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(21.60 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'4e7d2779-8373-4ebf-b1b6-e0c13dd4655f', N'Scrapper', N'003', CAST(N'2022-03-01' AS Date), CAST(N'2023-03-01' AS Date), CAST(22.15 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'e5a81386-75ee-48a7-96ed-a2c922e4b3fe', N'Scrapper', N'003', CAST(N'2023-04-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(24.15 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'c6579133-9f5a-4b9c-8414-a3251b69422e', N'Foreman', N'001', CAST(N'2023-01-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(13.55 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'9c3bc3b9-4942-4e94-9589-7597b81f416b', N'Foreman', N'002', CAST(N'2023-01-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(14.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[RateCards] ([Id], [Job], [Dept], [EffectiveStart], [EffectiveEnd], [HourlyRate]) VALUES (N'99460081-0124-46c6-97aa-393f388205d7', N'Foreman', N'003', CAST(N'2023-01-01' AS Date), CAST(N'2024-01-01' AS Date), CAST(15.60 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'f9fdb4bc-899b-42cf-bfd7-0478c3a5a5e0', N'Kyle James', N'110011', CAST(N'2023-06-01' AS Date), N'Overtime', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'bf72072c-43f4-4850-9a17-063d4d02d264', N'Kyle James', N'110011', CAST(N'2023-03-01' AS Date), N'Regular', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'd99a79bd-7935-4f14-b508-087577df1c7a', N'Kyle James', N'110011', CAST(N'2023-01-01' AS Date), N'Regular', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'5c1fec53-f31c-4cd9-8c22-29dd56fefe7d', N'Jane Smith', N'120987', CAST(N'2023-02-01' AS Date), N'Regular', N'Scrapper', N'002', CAST(10.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'e8af4d86-1d31-47f7-94e9-2bc6e5989c1b', N'Amy Penn', N'100002', CAST(N'2023-03-01' AS Date), N'Regular', N'Foreman', N'003', CAST(10.00 AS Decimal(18, 2)), CAST(17.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'd5653a29-f981-4b3e-a30c-4f0eae1ebd91', N'Kyle James', N'110011', CAST(N'2023-05-01' AS Date), N'Regular', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'71de76b5-3dba-455a-8481-5a7e61abcbad', N'Jane Smith', N'120987', CAST(N'2023-02-01' AS Date), N'Regular', N'Scrapper', N'002', CAST(10.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'2abdce70-b96e-44a4-9cd8-65c7c83477f7', N'Amy Penn', N'100002', CAST(N'2023-01-01' AS Date), N'Regular', N'Foreman', N'003', CAST(8.00 AS Decimal(18, 2)), CAST(17.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'a57d5acf-2eb4-4597-8899-6669e131d7e4', N'Amy Penn', N'100002', CAST(N'2023-02-01' AS Date), N'Regular', N'Foreman', N'003', CAST(12.00 AS Decimal(18, 2)), CAST(17.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'8641d226-b9cb-4b7b-ba09-7849861bfff4', N'Amy Penn', N'100002', CAST(N'2023-05-01' AS Date), N'Overtime', N'Foreman', N'003', CAST(5.00 AS Decimal(18, 2)), CAST(17.75 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'9a61161e-e287-4a9a-8d0d-7b6f29ddbb17', N'Jane Smith', N'120987', CAST(N'2023-05-01' AS Date), N'1/5/2023', N'Scrapper', N'004', CAST(6.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'40f45bfa-8c1e-41b0-9134-8e5755294027', N'Kyle James', N'110011', CAST(N'2023-02-01' AS Date), N'Regular', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'6dd22000-6ea0-4b3e-8cf7-97f5bb2f8c6b', N'Jane Smith', N'120987', CAST(N'2023-06-01' AS Date), N'Overtime', N'Scrapper', N'004', CAST(6.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'e279c24f-f6cd-4b2d-9250-bfd7e766716e', N'Amy Penn', N'100002', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'7d7903d7-f261-4c49-9813-c09f53661f50', N'Jane Smith', N'120987', CAST(N'2023-03-01' AS Date), N'Regular', N'Scrapper', N'002', CAST(10.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'4a2371b3-a81c-4bbd-ba3b-d2d2b73c4573', N'Jane Smith', N'120987', CAST(N'2023-07-01' AS Date), N'Double', N'Scrapper', N'004', CAST(5.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'6271a9a6-ad66-403b-ac3d-e6692fdb4eec', N'Jane Smith', N'20987', CAST(N'2023-04-01' AS Date), N'Regular', N'Scrapper', N'004', CAST(10.00 AS Decimal(18, 2)), CAST(17.65 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'45dfe31b-e6c1-41f4-b68b-ecd6c18f3c8e', N'Kyle James', N'110011', CAST(N'2023-04-01' AS Date), N'Regular', N'Laborer', N'001', CAST(8.00 AS Decimal(18, 2)), CAST(15.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TimeCards] ([Id], [EmployeeName], [EmployeeNumber], [DateWorked], [EarningsCode], [JobWorked], [DeptWorked], [Hours], [Rate], [Bonus]) VALUES (N'38da94c2-4d48-4a32-aed0-ede34ca15a5c', N'Amy Penn', N'100002', CAST(N'2023-04-01' AS Date), N'Regular', N'Foreman', N'003', CAST(10.00 AS Decimal(18, 2)), CAST(17.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
GO
ALTER TABLE [dbo].[RateCards] ADD  CONSTRAINT [DF_Table_1_id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[TimeCards] ADD  CONSTRAINT [DF_TimeCards_Id]  DEFAULT (newid()) FOR [Id]
GO
