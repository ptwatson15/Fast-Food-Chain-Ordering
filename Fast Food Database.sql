USE [FastFood]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 05-Nov-20 10:13:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[CUS_ID] [int] NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Mname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CUS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENU]    Script Date: 05-Nov-20 10:13:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[Menu_Id] [int] NOT NULL,
	[Food] [varchar](100) NOT NULL,
	[Price] [money] NULL,
	[Category] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Food] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 05-Nov-20 10:13:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[CUS_ID] [int] NULL,
	[Food] [varchar](100) NULL,
	[Quantity] [varchar](20) NOT NULL,
	[Price] [money] NULL,
	[DineTake] [varchar](20) NOT NULL,
	[Tab_Add] [varchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID]  AS ('ORDER'+right('000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED,
	[Time_Stamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CUSTOMER] ([CUS_ID], [Fname], [Lname], [Mname]) VALUES (1, N'Walt', N'White', N'E')
GO
INSERT [dbo].[CUSTOMER] ([CUS_ID], [Fname], [Lname], [Mname]) VALUES (2, N'Richard', N'Long', N'Jo')
GO
INSERT [dbo].[CUSTOMER] ([CUS_ID], [Fname], [Lname], [Mname]) VALUES (3, N'Robin', N'Brave', N'S')
GO
INSERT [dbo].[MENU] ([Menu_Id], [Food], [Price], [Category]) VALUES (1, N'Burger', 1.5000, N'Food')
GO
INSERT [dbo].[MENU] ([Menu_Id], [Food], [Price], [Category]) VALUES (2, N'Cheeseburger', 2.0000, N'Food')
GO
INSERT [dbo].[MENU] ([Menu_Id], [Food], [Price], [Category]) VALUES (4, N'Coke', 1.0000, N'Drink')
GO
INSERT [dbo].[MENU] ([Menu_Id], [Food], [Price], [Category]) VALUES (3, N'Sanwich', 3.5000, N'Food')
GO
SET IDENTITY_INSERT [dbo].[ORDERS] ON 
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (1, N'Sanwich', N'2', 7.0000, N'DINE IN', N'6', 7, CAST(N'2020-10-31T13:48:19.830' AS DateTime))
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (1, N'Burger', N'2', 3.0000, N'DINE IN', N'1', 9, CAST(N'2020-10-31T13:48:19.830' AS DateTime))
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (1, N'Cheeseburger', N'3', 6.0000, N'DINE IN', N'1', 10, CAST(N'2020-10-31T13:48:19.830' AS DateTime))
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (2, N'Coke', N'2', 2.0000, N'DINE IN', N'6', 12, CAST(N'2020-10-31T13:48:19.830' AS DateTime))
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (2, N'Burger', N'2', 3.0000, N'DINE IN', N'14', 13, CAST(N'2020-10-31T13:51:59.040' AS DateTime))
GO
INSERT [dbo].[ORDERS] ([CUS_ID], [Food], [Quantity], [Price], [DineTake], [Tab_Add], [ID], [Time_Stamp]) VALUES (3, N'Cheeseburger', N'2', 4.0000, N'DINE IN', N'16', 14, CAST(N'2020-10-31T13:58:06.260' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
GO
ALTER TABLE [dbo].[ORDERS] ADD  DEFAULT (getdate()) FOR [Time_Stamp]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD FOREIGN KEY([CUS_ID])
REFERENCES [dbo].[CUSTOMER] ([CUS_ID])
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD FOREIGN KEY([Food])
REFERENCES [dbo].[MENU] ([Food])
GO
