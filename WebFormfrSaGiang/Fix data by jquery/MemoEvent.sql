/****** Object:  Table [dbo].[MemoEvent]    Script Date: 07/09/2017 3:39:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MemoEvent]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MemoEvent](
	[MEID] [int] IDENTITY(1,1) NOT NULL,
	[METitle] [nvarchar](250) NULL,
	[MEContent] [nvarchar](500) NULL,
	[EventID] [int] NULL,
	[MELastUpdate] [datetime] NULL,
	[MEDateCreate] [datetime] NULL,
	[MEUserUpdate] [int] NULL,
	[MEUserCreate] [int] NULL,
 CONSTRAINT [PK_MemoEvent] PRIMARY KEY CLUSTERED 
(
	[MEID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent]  WITH CHECK ADD  CONSTRAINT [FK_MemoEvent_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent] CHECK CONSTRAINT [FK_MemoEvent_Event]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_UserAccountCreate]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent]  WITH CHECK ADD  CONSTRAINT [FK_MemoEvent_UserAccountCreate] FOREIGN KEY([MEUserCreate])
REFERENCES [dbo].[UserAccount] ([AccountID])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_UserAccountCreate]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent] CHECK CONSTRAINT [FK_MemoEvent_UserAccountCreate]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_UserAccountUpdate]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent]  WITH CHECK ADD  CONSTRAINT [FK_MemoEvent_UserAccountUpdate] FOREIGN KEY([MEUserUpdate])
REFERENCES [dbo].[UserAccount] ([AccountID])
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MemoEvent_UserAccountUpdate]') AND parent_object_id = OBJECT_ID(N'[dbo].[MemoEvent]'))
ALTER TABLE [dbo].[MemoEvent] CHECK CONSTRAINT [FK_MemoEvent_UserAccountUpdate]
GO


