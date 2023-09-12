CREATE TABLE [dbo].[Purchase]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Item] NVARCHAR(50) NOT NULL, 
    [Cost] MONEY NOT NULL, 
    [CustomerId] INT NOT NULL,
)
