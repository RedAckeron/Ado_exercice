CREATE TABLE [dbo].[Character](
	[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Strength] [int] NOT NULL DEFAULT 0,
	[Stamina] [int] NOT NULL DEFAULT 0,
	[Hp] [int] NOT NULL DEFAULT 0,
	[IsDead] [bit] NOT NULL DEFAULT 0,
	[CreationDate] [datetime2](7) NOT NULL DEFAULT GETDATE(),
	[Money] int not null default 0)



