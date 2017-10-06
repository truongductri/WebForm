/****** Object:  Table [dbo].[AttachFile]    Script Date: 07/09/2017 3:40:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttachFile]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AttachFile](
	[AttachFileID] [int] IDENTITY(1,1) NOT NULL,
	[AttachFileName] [nvarchar](250) NULL,
	[AttachFilePath] [nvarchar](1000) NULL,
	[AttachFileDate] [datetime] NULL,
	[EventID] [int] NULL,
	[UserCreate] [int] NULL,
 CONSTRAINT [PK_AttachFile] PRIMARY KEY CLUSTERED 
(
	[AttachFileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AttachFile_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[AttachFile]'))
ALTER TABLE [dbo].[AttachFile]  WITH CHECK ADD  CONSTRAINT [FK_AttachFile_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AttachFile_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[AttachFile]'))
ALTER TABLE [dbo].[AttachFile] CHECK CONSTRAINT [FK_AttachFile_Event]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AttachFile_UserAccount]') AND parent_object_id = OBJECT_ID(N'[dbo].[AttachFile]'))
ALTER TABLE [dbo].[AttachFile]  WITH CHECK ADD  CONSTRAINT [FK_AttachFile_UserAccount] FOREIGN KEY([UserCreate])
REFERENCES [dbo].[UserAccount] ([AccountID])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AttachFile_UserAccount]') AND parent_object_id = OBJECT_ID(N'[dbo].[AttachFile]'))
ALTER TABLE [dbo].[AttachFile] CHECK CONSTRAINT [FK_AttachFile_UserAccount]
GO


