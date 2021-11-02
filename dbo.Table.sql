CREATE TABLE [dbo].[Table_Client]
(
	[Id] INT
	PRIMARY KEY CLUSTERED ([Id] ASC) IDENTITY, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [BirthYear] INT NULL, 
    [PhoneNumber] NCHAR(50) NOT NULL, 
    [BtcAmount] FLOAT NULL, 
    [BtcAddress] NVARCHAR(50) NOT NULL, 
    [ShoeSize] INT NULL
)

