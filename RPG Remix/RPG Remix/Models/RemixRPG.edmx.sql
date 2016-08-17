
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/12/2016 12:08:43
-- Generated from EDMX file: C:\Users\Luiz de Queiroz\Dropbox\RolePlayingGame\Sistema\RPG Remix\RPG Remix\Models\RemixRPG.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [rpgremix];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FichaPropriedade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PropriedadeSet] DROP CONSTRAINT [FK_FichaPropriedade];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaPeculiaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PeculiaridadeSet] DROP CONSTRAINT [FK_FichaPeculiaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaRiqueza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RiquezaSet] DROP CONSTRAINT [FK_FichaRiqueza];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaItemArma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemArmaSet] DROP CONSTRAINT [FK_FichaItemArma];
GO
IF OBJECT_ID(N'[dbo].[FK_PropriedadeRegião]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PropriedadeSet] DROP CONSTRAINT [FK_PropriedadeRegião];
GO
IF OBJECT_ID(N'[dbo].[FK_MapaRegião]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegiãoSet] DROP CONSTRAINT [FK_MapaRegião];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioFicha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_UsuarioFicha];
GO
IF OBJECT_ID(N'[dbo].[FK_MesaFicha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_MesaFicha];
GO
IF OBJECT_ID(N'[dbo].[FK_MesaMapaMesa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MesaMapaSet] DROP CONSTRAINT [FK_MesaMapaMesa];
GO
IF OBJECT_ID(N'[dbo].[FK_MesaMapaMapa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MesaMapaSet] DROP CONSTRAINT [FK_MesaMapaMapa];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaVestimenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VestimentaSet] DROP CONSTRAINT [FK_FichaVestimenta];
GO
IF OBJECT_ID(N'[dbo].[FK_MesaUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MesaSet] DROP CONSTRAINT [FK_MesaUsuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MesaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MesaSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[FichaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FichaSet];
GO
IF OBJECT_ID(N'[dbo].[PeculiaridadeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeculiaridadeSet];
GO
IF OBJECT_ID(N'[dbo].[PropriedadeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PropriedadeSet];
GO
IF OBJECT_ID(N'[dbo].[RiquezaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RiquezaSet];
GO
IF OBJECT_ID(N'[dbo].[ItemArmaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemArmaSet];
GO
IF OBJECT_ID(N'[dbo].[VestimentaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VestimentaSet];
GO
IF OBJECT_ID(N'[dbo].[MapaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MapaSet];
GO
IF OBJECT_ID(N'[dbo].[RegiãoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegiãoSet];
GO
IF OBJECT_ID(N'[dbo].[MesaMapaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MesaMapaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MesaSet'
CREATE TABLE [dbo].[MesaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [NumeroJogadores] int  NULL,
    [DataCriacao] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [Sexo] tinyint  NOT NULL,
    [DataCadastro] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FichaSet'
CREATE TABLE [dbo].[FichaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL,
    [Raca] nvarchar(max)  NOT NULL,
    [Classe] nvarchar(max)  NOT NULL,
    [Adre] int  NOT NULL,
    [Ataq] int  NOT NULL,
    [Defe] int  NOT NULL,
    [Dest] int  NOT NULL,
    [Forc] int  NOT NULL,
    [Inte] int  NOT NULL,
    [Resi] int  NOT NULL,
    [Sabe] int  NOT NULL,
    [Velo] int  NOT NULL,
    [Vital] int  NOT NULL,
    [Sort] int  NOT NULL,
    [Suportes] int  NOT NULL,
    [MestreId] int  NULL,
    [UsuarioId] int  NOT NULL,
    [MesaId] int  NOT NULL,
    [PtsTestes] int  NOT NULL,
    [PtsPericias] int  NOT NULL,
    [PtsDesvantagens] int  NOT NULL,
    [PtsExperiencia] int  NOT NULL,
    [DataNivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PeculiaridadeSet'
CREATE TABLE [dbo].[PeculiaridadeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Teste] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [FichaId] int  NOT NULL
);
GO

-- Creating table 'PropriedadeSet'
CREATE TABLE [dbo].[PropriedadeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [CoordX] int  NULL,
    [CoordY] int  NULL,
    [CoordGX] int  NULL,
    [CoordGY] int  NULL,
    [FichaId] int  NOT NULL,
    [RegiãoId] int  NOT NULL
);
GO

-- Creating table 'RiquezaSet'
CREATE TABLE [dbo].[RiquezaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [FichaId] int  NOT NULL
);
GO

-- Creating table 'ItemArmaSet'
CREATE TABLE [dbo].[ItemArmaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Peso] float  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Dano] int  NOT NULL,
    [FichaId] int  NOT NULL
);
GO

-- Creating table 'VestimentaSet'
CREATE TABLE [dbo].[VestimentaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Testa] nvarchar(max)  NOT NULL,
    [Cara] nvarchar(max)  NOT NULL,
    [Pescoco] nvarchar(max)  NOT NULL,
    [OmbroD] nvarchar(max)  NOT NULL,
    [OmbroE] nvarchar(max)  NOT NULL,
    [BracoD] nvarchar(max)  NOT NULL,
    [BracoE] nvarchar(max)  NOT NULL,
    [AntebracoD] nvarchar(max)  NOT NULL,
    [AntebracoE] nvarchar(max)  NOT NULL,
    [MaoD] nvarchar(max)  NOT NULL,
    [MaoE] nvarchar(max)  NOT NULL,
    [PeitoD] nvarchar(max)  NOT NULL,
    [PeitoE] nvarchar(max)  NOT NULL,
    [Diafragma] nvarchar(max)  NOT NULL,
    [Abdomen] nvarchar(max)  NOT NULL,
    [Genital] nvarchar(max)  NOT NULL,
    [CoxaD] nvarchar(max)  NOT NULL,
    [CoxaE] nvarchar(max)  NOT NULL,
    [JoelhoD] nvarchar(max)  NOT NULL,
    [JoelhoE] nvarchar(max)  NOT NULL,
    [CanelaD] nvarchar(max)  NOT NULL,
    [CanelaE] nvarchar(max)  NOT NULL,
    [PeD] nvarchar(max)  NOT NULL,
    [PeE] nvarchar(max)  NOT NULL,
    [FichaId] int  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'MapaSet'
CREATE TABLE [dbo].[MapaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Caminho] nvarchar(max)  NOT NULL,
    [Geral] bit  NOT NULL
);
GO

-- Creating table 'RegiãoSet'
CREATE TABLE [dbo].[RegiãoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [MapaId] int  NOT NULL
);
GO

-- Creating table 'MesaMapaSet'
CREATE TABLE [dbo].[MesaMapaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MesaId] int  NOT NULL,
    [MapaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MesaSet'
ALTER TABLE [dbo].[MesaSet]
ADD CONSTRAINT [PK_MesaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [PK_FichaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PeculiaridadeSet'
ALTER TABLE [dbo].[PeculiaridadeSet]
ADD CONSTRAINT [PK_PeculiaridadeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PropriedadeSet'
ALTER TABLE [dbo].[PropriedadeSet]
ADD CONSTRAINT [PK_PropriedadeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RiquezaSet'
ALTER TABLE [dbo].[RiquezaSet]
ADD CONSTRAINT [PK_RiquezaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemArmaSet'
ALTER TABLE [dbo].[ItemArmaSet]
ADD CONSTRAINT [PK_ItemArmaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VestimentaSet'
ALTER TABLE [dbo].[VestimentaSet]
ADD CONSTRAINT [PK_VestimentaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MapaSet'
ALTER TABLE [dbo].[MapaSet]
ADD CONSTRAINT [PK_MapaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RegiãoSet'
ALTER TABLE [dbo].[RegiãoSet]
ADD CONSTRAINT [PK_RegiãoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MesaMapaSet'
ALTER TABLE [dbo].[MesaMapaSet]
ADD CONSTRAINT [PK_MesaMapaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FichaId] in table 'PropriedadeSet'
ALTER TABLE [dbo].[PropriedadeSet]
ADD CONSTRAINT [FK_FichaPropriedade]
    FOREIGN KEY ([FichaId])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaPropriedade'
CREATE INDEX [IX_FK_FichaPropriedade]
ON [dbo].[PropriedadeSet]
    ([FichaId]);
GO

-- Creating foreign key on [FichaId] in table 'PeculiaridadeSet'
ALTER TABLE [dbo].[PeculiaridadeSet]
ADD CONSTRAINT [FK_FichaPeculiaridade]
    FOREIGN KEY ([FichaId])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaPeculiaridade'
CREATE INDEX [IX_FK_FichaPeculiaridade]
ON [dbo].[PeculiaridadeSet]
    ([FichaId]);
GO

-- Creating foreign key on [FichaId] in table 'RiquezaSet'
ALTER TABLE [dbo].[RiquezaSet]
ADD CONSTRAINT [FK_FichaRiqueza]
    FOREIGN KEY ([FichaId])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaRiqueza'
CREATE INDEX [IX_FK_FichaRiqueza]
ON [dbo].[RiquezaSet]
    ([FichaId]);
GO

-- Creating foreign key on [FichaId] in table 'ItemArmaSet'
ALTER TABLE [dbo].[ItemArmaSet]
ADD CONSTRAINT [FK_FichaItemArma]
    FOREIGN KEY ([FichaId])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaItemArma'
CREATE INDEX [IX_FK_FichaItemArma]
ON [dbo].[ItemArmaSet]
    ([FichaId]);
GO

-- Creating foreign key on [RegiãoId] in table 'PropriedadeSet'
ALTER TABLE [dbo].[PropriedadeSet]
ADD CONSTRAINT [FK_PropriedadeRegião]
    FOREIGN KEY ([RegiãoId])
    REFERENCES [dbo].[RegiãoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PropriedadeRegião'
CREATE INDEX [IX_FK_PropriedadeRegião]
ON [dbo].[PropriedadeSet]
    ([RegiãoId]);
GO

-- Creating foreign key on [MapaId] in table 'RegiãoSet'
ALTER TABLE [dbo].[RegiãoSet]
ADD CONSTRAINT [FK_MapaRegião]
    FOREIGN KEY ([MapaId])
    REFERENCES [dbo].[MapaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MapaRegião'
CREATE INDEX [IX_FK_MapaRegião]
ON [dbo].[RegiãoSet]
    ([MapaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_UsuarioFicha]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFicha'
CREATE INDEX [IX_FK_UsuarioFicha]
ON [dbo].[FichaSet]
    ([UsuarioId]);
GO

-- Creating foreign key on [MesaId] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_MesaFicha]
    FOREIGN KEY ([MesaId])
    REFERENCES [dbo].[MesaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaFicha'
CREATE INDEX [IX_FK_MesaFicha]
ON [dbo].[FichaSet]
    ([MesaId]);
GO

-- Creating foreign key on [MesaId] in table 'MesaMapaSet'
ALTER TABLE [dbo].[MesaMapaSet]
ADD CONSTRAINT [FK_MesaMapaMesa]
    FOREIGN KEY ([MesaId])
    REFERENCES [dbo].[MesaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaMapaMesa'
CREATE INDEX [IX_FK_MesaMapaMesa]
ON [dbo].[MesaMapaSet]
    ([MesaId]);
GO

-- Creating foreign key on [MapaId] in table 'MesaMapaSet'
ALTER TABLE [dbo].[MesaMapaSet]
ADD CONSTRAINT [FK_MesaMapaMapa]
    FOREIGN KEY ([MapaId])
    REFERENCES [dbo].[MapaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaMapaMapa'
CREATE INDEX [IX_FK_MesaMapaMapa]
ON [dbo].[MesaMapaSet]
    ([MapaId]);
GO

-- Creating foreign key on [FichaId] in table 'VestimentaSet'
ALTER TABLE [dbo].[VestimentaSet]
ADD CONSTRAINT [FK_FichaVestimenta]
    FOREIGN KEY ([FichaId])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaVestimenta'
CREATE INDEX [IX_FK_FichaVestimenta]
ON [dbo].[VestimentaSet]
    ([FichaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'MesaSet'
ALTER TABLE [dbo].[MesaSet]
ADD CONSTRAINT [FK_MesaUsuario]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaUsuario'
CREATE INDEX [IX_FK_MesaUsuario]
ON [dbo].[MesaSet]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------