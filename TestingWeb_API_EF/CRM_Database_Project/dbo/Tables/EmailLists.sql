CREATE TABLE [dbo].[EmailLists] (
    [EmailListID]   INT           IDENTITY (1, 1) NOT NULL,
    [EmailListName] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_EmailLists] PRIMARY KEY CLUSTERED ([EmailListID] ASC)
);

