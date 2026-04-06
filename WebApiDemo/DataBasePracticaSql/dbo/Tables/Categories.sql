CREATE TABLE [dbo].[Categories] (
    [IdCategory] INT IDENTITY (1,1) NOT NULL,
    [Name] NVARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([IdCategory] ASC)
);