CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] DECIMAL NULL, 
    [Descriptions] VARCHAR(200) NULL, 
    CONSTRAINT [Brand_Car] FOREIGN KEY ([BrandId]) REFERENCES [Brands]([BrandId]), 
    CONSTRAINT [Color_Car] FOREIGN KEY ([ColorId]) REFERENCES [Colors]([ColorId])
)
