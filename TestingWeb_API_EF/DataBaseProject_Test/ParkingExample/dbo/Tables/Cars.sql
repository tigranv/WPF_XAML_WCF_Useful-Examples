CREATE TABLE [dbo].[Cars] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Mark]  VARCHAR (100) NULL,
    [Model] VARCHAR (100) NULL,
    [year]  INT           NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

