CREATE TABLE [dbo].[Inventory]
(
	[Id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Id_char] int REFERENCES [Character](id),
	[Id_item] int REFERENCES [Item](id),
	[Quantity] int
)