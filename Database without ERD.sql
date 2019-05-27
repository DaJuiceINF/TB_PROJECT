USE [CuosisTB]
GO
/****** Object:  Table [dbo].[AccessLevel]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccessLevel](
	[AccessLevel_ID] [int] NOT NULL,
	[AccessLevel_description] [varchar](50) NULL,
 CONSTRAINT [PK_AccessLevel] PRIMARY KEY CLUSTERED 
(
	[AccessLevel_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Allergies]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Allergies](
	[AllergiesID] [int] NOT NULL,
	[medicineID] [int] NULL,
	[patientID] [int] NULL,
	[Allergies_Description] [varchar](50) NULL,
	[Med_Allergies_ID] [int] NULL,
	[Patient_Allergies_ID] [int] NULL,
 CONSTRAINT [PK_Allergies] PRIMARY KEY CLUSTERED 
(
	[AllergiesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doc_Center]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_Center](
	[Doc_Center_ID] [int] NOT NULL,
	[DoctorID] [int] NULL,
	[Medical_Center_ID] [int] NULL,
 CONSTRAINT [PK_Doc_Center] PRIMARY KEY CLUSTERED 
(
	[Doc_Center_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[DoctorID] [int] NOT NULL,
	[Medical_Center_ID] [int] NULL,
	[Doctor_Name] [varchar](50) NULL,
	[Contact_Details] [numeric](18, 0) NULL,
	[OtherDetails] [varchar](50) NULL,
	[patientID] [int] NULL,
	[Patients_Doc_ID] [int] NULL,
	[Doc_Center_ID] [int] NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employeemasters]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employeemasters](
	[UserId] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[LoginName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ContactNo] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[IsApporved] [int] NULL,
	[Status] [int] NULL,
	[TotalCnt] [int] NULL,
	[AccessLevel_ID] [int] NULL,
	[RegisterID] [int] NULL,
 CONSTRAINT [PK_Employeemasters] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Med_Allergies]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Med_Allergies](
	[Med_Allergies_ID] [int] NOT NULL,
	[AllergiesID] [int] NULL,
	[medicineID] [int] NULL,
 CONSTRAINT [PK_Med_Allergies] PRIMARY KEY CLUSTERED 
(
	[Med_Allergies_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medical_Center]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medical_Center](
	[Medical_Center_ID] [int] NOT NULL,
	[Building] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Zip_Code] [varchar](50) NULL,
	[Other_Details] [varchar](50) NULL,
	[Doc_Center_ID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicine](
	[medicineID] [int] NOT NULL,
	[medicineName] [varchar](50) NULL,
	[medicineDescription] [varchar](50) NULL,
	[estimatePrice] [varchar](50) NULL,
	[TB_Type_ID] [int] NULL,
	[Med_Allergies_ID] [nchar](10) NULL,
	[Symptons_Med_ID] [int] NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[medicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient_Allergies]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Allergies](
	[Patient_Allergies_ID] [int] NOT NULL,
	[AllergiesID] [int] NULL,
	[patientID] [int] NULL,
 CONSTRAINT [PK_Patient_Allergies] PRIMARY KEY CLUSTERED 
(
	[Patient_Allergies_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patients](
	[patientID] [int] NOT NULL,
	[patientFullName] [varchar](50) NULL,
	[patientGenderID] [int] NULL,
	[patientStatus] [varchar](50) NULL,
	[contactNumber] [numeric](18, 0) NULL,
	[patientAdress] [varchar](50) NULL,
	[patientNationality] [varchar](50) NULL,
	[Patient_Allergies_ID] [int] NULL,
	[Patients_Med_ID] [int] NULL,
	[Patient_Symtom_ID] [int] NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patients_Doc]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients_Doc](
	[Patients_Doc_ID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
 CONSTRAINT [PK_Patients_Doc] PRIMARY KEY CLUSTERED 
(
	[Patients_Doc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients_Med]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients_Med](
	[Patients_Med_ID] [int] NOT NULL,
	[medicineID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
 CONSTRAINT [PK_Patients_Med] PRIMARY KEY CLUSTERED 
(
	[Patients_Med_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Register]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Register](
	[RegisterID] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ContactNo] [varchar](50) NULL,
	[Address] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Symptons]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Symptons](
	[symptomID] [int] NOT NULL,
	[symptomDescription] [varchar](50) NULL,
	[TB_Type_ID] [int] NULL,
	[Symptons_Med_ID] [int] NULL,
	[Patient_Symtom_ID] [int] NULL,
 CONSTRAINT [PK_Symptons] PRIMARY KEY CLUSTERED 
(
	[symptomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Symptons_Medication]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Symptons_Medication](
	[Symptons_Med_ID] [int] NOT NULL,
	[medicineID] [int] NULL,
	[symptomID] [int] NULL,
 CONSTRAINT [PK_Symptons_Medication] PRIMARY KEY CLUSTERED 
(
	[Symptons_Med_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Type]    Script Date: 2019/05/14 12:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_Type](
	[TB_Type_ID] [int] NOT NULL,
	[TB_Type_Description] [varchar](50) NULL,
	[symptomID] [int] NULL,
 CONSTRAINT [PK_TB_Type] PRIMARY KEY CLUSTERED 
(
	[TB_Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Allergies]  WITH CHECK ADD  CONSTRAINT [FK_Allergies_Allergies] FOREIGN KEY([AllergiesID])
REFERENCES [dbo].[Allergies] ([AllergiesID])
GO
ALTER TABLE [dbo].[Allergies] CHECK CONSTRAINT [FK_Allergies_Allergies]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([DoctorID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Doctor]
GO
