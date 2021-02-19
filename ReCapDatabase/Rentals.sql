CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [RentDate] DATE NULL, 
    [ReturnDate] DATE NULL, 
    CONSTRAINT [CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars]([CarId]), 
    CONSTRAINT [CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([CustomerId])
)
