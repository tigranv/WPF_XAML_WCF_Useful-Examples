CREATE TABLE [dbo].[Partners] (
    [PartnerID]   INT           IDENTITY (1, 1) NOT NULL,
    [FullName]    VARCHAR (100) NOT NULL,
    [CompanyName] VARCHAR (200) NULL,
    [Position]    VARCHAR (50)  NULL,
    [Email]       VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Partners] PRIMARY KEY CLUSTERED ([PartnerID] ASC)
);

