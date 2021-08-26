
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/26/2021 11:16:41
-- Generated from EDMX file: C:\Users\Henrique\documents\visual studio 2015\Projects\Rent_Books\Rent_Books\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RentBook_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserRent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentSet] DROP CONSTRAINT [FK_UserRent];
GO
IF OBJECT_ID(N'[dbo].[FK_BookRent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentSet] DROP CONSTRAINT [FK_BookRent];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[RentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentSet];
GO
IF OBJECT_ID(N'[dbo].[BookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'RentSet'
CREATE TABLE [dbo].[RentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateStart] datetime  NOT NULL,
    [User_id] int  NOT NULL,
    [Book_Id] int  NOT NULL,
    [State] bit  NOT NULL,
    [DateEnd] datetime  NOT NULL
);
GO

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [Quantity] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RentSet'
ALTER TABLE [dbo].[RentSet]
ADD CONSTRAINT [PK_RentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_id] in table 'RentSet'
ALTER TABLE [dbo].[RentSet]
ADD CONSTRAINT [FK_UserRent]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRent'
CREATE INDEX [IX_FK_UserRent]
ON [dbo].[RentSet]
    ([User_id]);
GO

-- Creating foreign key on [Book_Id] in table 'RentSet'
ALTER TABLE [dbo].[RentSet]
ADD CONSTRAINT [FK_BookRent]
    FOREIGN KEY ([Book_Id])
    REFERENCES [dbo].[BookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookRent'
CREATE INDEX [IX_FK_BookRent]
ON [dbo].[RentSet]
    ([Book_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------