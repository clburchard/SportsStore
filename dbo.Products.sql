CREATE TABLE Products (
    [ProductID]   INT  NOT NULL PRIMARY KEY IDENTITY,
    [Name]        NVARCHAR (100)  NULL,
    [Description] NVARCHAR (500)  NULL,
    [Price]       DECIMAL (16, 2) NOT NULL,
    [Category]    NVARCHAR (50)  NULL,
);

