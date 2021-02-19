CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [CompanyName] VARCHAR(100) NULL, 
    CONSTRAINT [Customer_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
