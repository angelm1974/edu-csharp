
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2021 14:18:36
-- Generated from EDMX file: C:\Users\mariu\source\repos\Baza2\Baza2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [biblioteka];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ksiazkawypozyczenie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[wypozyczenieSet] DROP CONSTRAINT [FK_ksiazkawypozyczenie];
GO
IF OBJECT_ID(N'[dbo].[FK_czytelnikwypozyczenie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[wypozyczenieSet] DROP CONSTRAINT [FK_czytelnikwypozyczenie];
GO
IF OBJECT_ID(N'[dbo].[FK_bibliotekarzwypozyczenie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bibliotekarzSet] DROP CONSTRAINT [FK_bibliotekarzwypozyczenie];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ksiazkaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ksiazkaSet];
GO
IF OBJECT_ID(N'[dbo].[czytelnikSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czytelnikSet];
GO
IF OBJECT_ID(N'[dbo].[wypozyczenieSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[wypozyczenieSet];
GO
IF OBJECT_ID(N'[dbo].[bibliotekarzSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bibliotekarzSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ksiazkaSet'
CREATE TABLE [dbo].[ksiazkaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [tytul] nvarchar(max)  NOT NULL,
    [autor] nvarchar(max)  NOT NULL,
    [wydanie] smallint  NOT NULL,
    [wydawca] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'wypozyczenieSet'
CREATE TABLE [dbo].[wypozyczenieSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dataWypozyczenia] datetime  NOT NULL,
    [dataZwrotu] datetime  NOT NULL,
    [ksiazka_Id] int  NOT NULL,
    [czytelnik_Id] int  NOT NULL
);
GO

-- Creating table 'czlowiekSet'
CREATE TABLE [dbo].[czlowiekSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [imie] nvarchar(max)  NOT NULL,
    [nazwisko] nvarchar(max)  NOT NULL,
    [wiek] smallint  NOT NULL
);
GO

-- Creating table 'czlowiekSet_czytelnik'
CREATE TABLE [dbo].[czlowiekSet_czytelnik] (
    [IdC] int IDENTITY(1,1) NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'czlowiekSet_bibliotekarz'
CREATE TABLE [dbo].[czlowiekSet_bibliotekarz] (
    [IdB] int IDENTITY(1,1) NOT NULL,
    [stazPracy] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [wypozyczenie_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ksiazkaSet'
ALTER TABLE [dbo].[ksiazkaSet]
ADD CONSTRAINT [PK_ksiazkaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'wypozyczenieSet'
ALTER TABLE [dbo].[wypozyczenieSet]
ADD CONSTRAINT [PK_wypozyczenieSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'czlowiekSet'
ALTER TABLE [dbo].[czlowiekSet]
ADD CONSTRAINT [PK_czlowiekSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'czlowiekSet_czytelnik'
ALTER TABLE [dbo].[czlowiekSet_czytelnik]
ADD CONSTRAINT [PK_czlowiekSet_czytelnik]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'czlowiekSet_bibliotekarz'
ALTER TABLE [dbo].[czlowiekSet_bibliotekarz]
ADD CONSTRAINT [PK_czlowiekSet_bibliotekarz]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ksiazka_Id] in table 'wypozyczenieSet'
ALTER TABLE [dbo].[wypozyczenieSet]
ADD CONSTRAINT [FK_ksiazkawypozyczenie]
    FOREIGN KEY ([ksiazka_Id])
    REFERENCES [dbo].[ksiazkaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ksiazkawypozyczenie'
CREATE INDEX [IX_FK_ksiazkawypozyczenie]
ON [dbo].[wypozyczenieSet]
    ([ksiazka_Id]);
GO

-- Creating foreign key on [czytelnik_Id] in table 'wypozyczenieSet'
ALTER TABLE [dbo].[wypozyczenieSet]
ADD CONSTRAINT [FK_czytelnikwypozyczenie]
    FOREIGN KEY ([czytelnik_Id])
    REFERENCES [dbo].[czlowiekSet_czytelnik]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_czytelnikwypozyczenie'
CREATE INDEX [IX_FK_czytelnikwypozyczenie]
ON [dbo].[wypozyczenieSet]
    ([czytelnik_Id]);
GO

-- Creating foreign key on [wypozyczenie_Id] in table 'czlowiekSet_bibliotekarz'
ALTER TABLE [dbo].[czlowiekSet_bibliotekarz]
ADD CONSTRAINT [FK_bibliotekarzwypozyczenie]
    FOREIGN KEY ([wypozyczenie_Id])
    REFERENCES [dbo].[wypozyczenieSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_bibliotekarzwypozyczenie'
CREATE INDEX [IX_FK_bibliotekarzwypozyczenie]
ON [dbo].[czlowiekSet_bibliotekarz]
    ([wypozyczenie_Id]);
GO

-- Creating foreign key on [Id] in table 'czlowiekSet_czytelnik'
ALTER TABLE [dbo].[czlowiekSet_czytelnik]
ADD CONSTRAINT [FK_czytelnik_inherits_czlowiek]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[czlowiekSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'czlowiekSet_bibliotekarz'
ALTER TABLE [dbo].[czlowiekSet_bibliotekarz]
ADD CONSTRAINT [FK_bibliotekarz_inherits_czlowiek]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[czlowiekSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------