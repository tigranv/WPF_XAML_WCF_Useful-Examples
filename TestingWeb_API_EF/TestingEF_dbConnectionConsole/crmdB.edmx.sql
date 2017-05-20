
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/20/2017 19:19:02
-- Generated from EDMX file: C:\Users\Tigran PC\Source\Repos\WPF_XAML_WCF_Useful-Examples\TestingWeb_API_EF\TestingEF_dbConnectionConsole\crmdB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BetC_CRM_Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__EmailList__Email__398D8EEE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmailListPartners] DROP CONSTRAINT [FK__EmailList__Email__398D8EEE];
GO
IF OBJECT_ID(N'[dbo].[FK__EmailList__Partn__3A81B327]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmailListPartners] DROP CONSTRAINT [FK__EmailList__Partn__3A81B327];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmailListPartners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmailListPartners];
GO
IF OBJECT_ID(N'[dbo].[EmailLists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmailLists];
GO
IF OBJECT_ID(N'[dbo].[Partners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Partners];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmailLists'
CREATE TABLE [dbo].[EmailLists] (
    [EmailListID] int IDENTITY(1,1) NOT NULL,
    [EmailListName] varchar(200)  NOT NULL
);
GO

-- Creating table 'Partners'
CREATE TABLE [dbo].[Partners] (
    [PartnerID] int IDENTITY(1,1) NOT NULL,
    [FullName] varchar(100)  NOT NULL,
    [CompanyName] varchar(200)  NULL,
    [Position] varchar(50)  NULL,
    [Email] varchar(150)  NOT NULL
);
GO

-- Creating table 'EmailListPartners'
CREATE TABLE [dbo].[EmailListPartners] (
    [EmailLists_EmailListID] int  NOT NULL,
    [Partners_PartnerID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmailListID] in table 'EmailLists'
ALTER TABLE [dbo].[EmailLists]
ADD CONSTRAINT [PK_EmailLists]
    PRIMARY KEY CLUSTERED ([EmailListID] ASC);
GO

-- Creating primary key on [PartnerID] in table 'Partners'
ALTER TABLE [dbo].[Partners]
ADD CONSTRAINT [PK_Partners]
    PRIMARY KEY CLUSTERED ([PartnerID] ASC);
GO

-- Creating primary key on [EmailLists_EmailListID], [Partners_PartnerID] in table 'EmailListPartners'
ALTER TABLE [dbo].[EmailListPartners]
ADD CONSTRAINT [PK_EmailListPartners]
    PRIMARY KEY CLUSTERED ([EmailLists_EmailListID], [Partners_PartnerID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmailLists_EmailListID] in table 'EmailListPartners'
ALTER TABLE [dbo].[EmailListPartners]
ADD CONSTRAINT [FK_EmailListPartners_EmailLists]
    FOREIGN KEY ([EmailLists_EmailListID])
    REFERENCES [dbo].[EmailLists]
        ([EmailListID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Partners_PartnerID] in table 'EmailListPartners'
ALTER TABLE [dbo].[EmailListPartners]
ADD CONSTRAINT [FK_EmailListPartners_Partners]
    FOREIGN KEY ([Partners_PartnerID])
    REFERENCES [dbo].[Partners]
        ([PartnerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmailListPartners_Partners'
CREATE INDEX [IX_FK_EmailListPartners_Partners]
ON [dbo].[EmailListPartners]
    ([Partners_PartnerID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------