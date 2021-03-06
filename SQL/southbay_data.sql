/****** Object:  Table [dbo].[aspnet_Membership]    Script Date: 11/20/2012 11:10:27 ******/
DELETE FROM [dbo].[aspnet_Membership]
GO
/****** Object:  Table [dbo].[aspnet_Users]    Script Date: 11/20/2012 11:10:27 ******/
DELETE FROM [dbo].[aspnet_Users]
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 11/20/2012 11:10:27 ******/
DELETE FROM [dbo].[reservation]
GO
/****** Object:  Table [dbo].[aspnet_SchemaVersions]    Script Date: 11/20/2012 11:10:27 ******/
DELETE FROM [dbo].[aspnet_SchemaVersions]
GO
/****** Object:  Table [dbo].[aspnet_Applications]    Script Date: 11/20/2012 11:10:27 ******/
DELETE FROM [dbo].[aspnet_Applications]
GO
/****** Object:  Table [dbo].[aspnet_Applications]    Script Date: 11/20/2012 11:10:27 ******/
INSERT [dbo].[aspnet_Applications] ([ApplicationName], [LoweredApplicationName], [ApplicationId], [Description]) VALUES (N'/', N'/', N'88dee53f-d641-40e0-b7ec-a64efc68322b', NULL)
/****** Object:  Table [dbo].[aspnet_SchemaVersions]    Script Date: 11/20/2012 11:10:27 ******/
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'common', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'membership', N'1', 1)
/****** Object:  Table [dbo].[reservation]    Script Date: 11/20/2012 11:10:27 ******/
SET IDENTITY_INSERT [dbo].[reservation] ON
INSERT [dbo].[reservation] ([Id], [Name], [StartDate], [EndDate], [Phone], [Email]) VALUES (1, N'Kruszka', CAST(0xA1BC0000 AS SmallDateTime), CAST(0xA1C20000 AS SmallDateTime), N'414-852-8125', N'j@test.com')
INSERT [dbo].[reservation] ([Id], [Name], [StartDate], [EndDate], [Phone], [Email]) VALUES (2, N'Hicks', CAST(0xA1C30000 AS SmallDateTime), CAST(0xA1C90000 AS SmallDateTime), N'414-666-3333', N'h@test.com')
INSERT [dbo].[reservation] ([Id], [Name], [StartDate], [EndDate], [Phone], [Email]) VALUES (4, N'Roter', CAST(0xA1CC0000 AS SmallDateTime), CAST(0xA1CF0000 AS SmallDateTime), N'414-222-3333', NULL)
INSERT [dbo].[reservation] ([Id], [Name], [StartDate], [EndDate], [Phone], [Email]) VALUES (5, N'Smith', CAST(0xA1D80000 AS SmallDateTime), CAST(0xA1DE0000 AS SmallDateTime), N'414-999-2222', NULL)
SET IDENTITY_INSERT [dbo].[reservation] OFF
/****** Object:  Table [dbo].[aspnet_Users]    Script Date: 11/20/2012 11:10:27 ******/
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'88dee53f-d641-40e0-b7ec-a64efc68322b', N'06b9e752-d367-4770-925c-19ab5b36465a', N'admin', N'admin', NULL, 0, CAST(0x0000A1030008EA69 AS DateTime))
/****** Object:  Table [dbo].[aspnet_Membership]    Script Date: 11/20/2012 11:10:27 ******/
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'88dee53f-d641-40e0-b7ec-a64efc68322b', N'06b9e752-d367-4770-925c-19ab5b36465a', N'OXCwXI6IpgtZFhiAen6rIqdTLPU=', 1, N'R/QpX13HX7k7HIEv6581zA==', NULL, N'jerod_kruszka@hotmail.com', N'jerod_kruszka@hotmail.com', NULL, NULL, 1, 0, CAST(0x0000A0F90113E86C AS DateTime), CAST(0x0000A1030008EA69 AS DateTime), CAST(0x0000A0F90113E86C AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
