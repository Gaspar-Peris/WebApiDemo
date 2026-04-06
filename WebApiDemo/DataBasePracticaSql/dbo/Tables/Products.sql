CREATE TABLE [dbo].[Products] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Price]       DECIMAL (18, 4) NOT NULL,
    [Notes]       NVARCHAR (MAX)  NULL,
    [IdCategory] INT NOT NULL,

    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),

    CONSTRAINT [FK_Products_Categories]
        FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Categories](IdCategory)
);

