
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/21/2016 20:39:48
-- Generated from EDMX file: C:\Repos\Sistema\RPG Remix\RPG Remix\Models\RemixRPG.edmx
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
IF OBJECT_ID(N'[dbo].[FK_FichaPontosAcumulados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_FichaPontosAcumulados];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaExperiencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_FichaExperiencia];
GO
IF OBJECT_ID(N'[dbo].[FK_FichaVestimenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VestimentaSet] DROP CONSTRAINT [FK_FichaVestimenta];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemArmaVestimenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VestimentaSet] DROP CONSTRAINT [FK_ItemArmaVestimenta];
GO
IF OBJECT_ID(N'[dbo].[FK_MesaJogador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JogadorSet] DROP CONSTRAINT [FK_MesaJogador];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioJogador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JogadorSet] DROP CONSTRAINT [FK_UsuarioJogador];
GO
IF OBJECT_ID(N'[dbo].[FK_JogadorFicha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JogadorSet] DROP CONSTRAINT [FK_JogadorFicha];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioMestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MestreSet] DROP CONSTRAINT [FK_UsuarioMestre];
GO
IF OBJECT_ID(N'[dbo].[FK_MestreMesa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MesaSet] DROP CONSTRAINT [FK_MestreMesa];
GO
IF OBJECT_ID(N'[dbo].[FK_MestreFicha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_MestreFicha];
GO
IF OBJECT_ID(N'[dbo].[FK_RegiãoPropriedade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PropriedadeSet] DROP CONSTRAINT [FK_RegiãoPropriedade];
GO
IF OBJECT_ID(N'[dbo].[FK_MapaRegião]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegiãoSet] DROP CONSTRAINT [FK_MapaRegião];
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
IF OBJECT_ID(N'[dbo].[ExperienciaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExperienciaSet];
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
IF OBJECT_ID(N'[dbo].[PontosAcumuladosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PontosAcumuladosSet];
GO
IF OBJECT_ID(N'[dbo].[JogadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JogadorSet];
GO
IF OBJECT_ID(N'[dbo].[MestreSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MestreSet];
GO
IF OBJECT_ID(N'[dbo].[MapaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MapaSet];
GO
IF OBJECT_ID(N'[dbo].[RegiãoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegiãoSet];
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
    [Mestre_Id] int  NOT NULL
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
    [PontosAcumulados_Id] int  NOT NULL,
    [Experiencia_Id] int  NOT NULL
);
GO

-- Creating table 'ExperienciaSet'
CREATE TABLE [dbo].[ExperienciaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pontos] int  NOT NULL,
    [Data] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PeculiaridadeSet'
CREATE TABLE [dbo].[PeculiaridadeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
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
    [ItemArma_Id] int  NOT NULL,
    [Ficha_Id] int  NOT NULL
);
GO

-- Creating table 'PontosAcumuladosSet'
CREATE TABLE [dbo].[PontosAcumuladosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Testes] int  NOT NULL,
    [Pericias] int  NOT NULL,
    [Desvantagens] int  NOT NULL
);
GO

-- Creating table 'JogadorSet'
CREATE TABLE [dbo].[JogadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MesaId] int  NOT NULL,
    [UsuarioId] int  NOT NULL,
    [Ficha_Id] int  NOT NULL
);
GO

-- Creating table 'MestreSet'
CREATE TABLE [dbo].[MestreSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'MapaSet'
CREATE TABLE [dbo].[MapaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Caminho] nvarchar(max)  NOT NULL,
    [Geral] bit  NOT NULL
);
GO

-- Creating table 'RegiãoSet'
CREATE TABLE [dbo].[RegiãoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [MapaId] int  NOT NULL
);
GO

-- Creating table 'MesaMapa'
CREATE TABLE [dbo].[MesaMapa] (
    [Mesas_Id] int  NOT NULL,
    [Mapas_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'ExperienciaSet'
ALTER TABLE [dbo].[ExperienciaSet]
ADD CONSTRAINT [PK_ExperienciaSet]
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

-- Creating primary key on [Id] in table 'PontosAcumuladosSet'
ALTER TABLE [dbo].[PontosAcumuladosSet]
ADD CONSTRAINT [PK_PontosAcumuladosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [PK_JogadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MestreSet'
ALTER TABLE [dbo].[MestreSet]
ADD CONSTRAINT [PK_MestreSet]
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

-- Creating primary key on [Mesas_Id], [Mapas_Id] in table 'MesaMapa'
ALTER TABLE [dbo].[MesaMapa]
ADD CONSTRAINT [PK_MesaMapa]
    PRIMARY KEY CLUSTERED ([Mesas_Id], [Mapas_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PontosAcumulados_Id] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_FichaPontosAcumulados]
    FOREIGN KEY ([PontosAcumulados_Id])
    REFERENCES [dbo].[PontosAcumuladosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaPontosAcumulados'
CREATE INDEX [IX_FK_FichaPontosAcumulados]
ON [dbo].[FichaSet]
    ([PontosAcumulados_Id]);
GO

-- Creating foreign key on [Experiencia_Id] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_FichaExperiencia]
    FOREIGN KEY ([Experiencia_Id])
    REFERENCES [dbo].[ExperienciaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaExperiencia'
CREATE INDEX [IX_FK_FichaExperiencia]
ON [dbo].[FichaSet]
    ([Experiencia_Id]);
GO

-- Creating foreign key on [ItemArma_Id] in table 'VestimentaSet'
ALTER TABLE [dbo].[VestimentaSet]
ADD CONSTRAINT [FK_ItemArmaVestimenta]
    FOREIGN KEY ([ItemArma_Id])
    REFERENCES [dbo].[ItemArmaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemArmaVestimenta'
CREATE INDEX [IX_FK_ItemArmaVestimenta]
ON [dbo].[VestimentaSet]
    ([ItemArma_Id]);
GO

-- Creating foreign key on [Mesas_Id] in table 'MesaMapa'
ALTER TABLE [dbo].[MesaMapa]
ADD CONSTRAINT [FK_MesaMapa_Mesa]
    FOREIGN KEY ([Mesas_Id])
    REFERENCES [dbo].[MesaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Mapas_Id] in table 'MesaMapa'
ALTER TABLE [dbo].[MesaMapa]
ADD CONSTRAINT [FK_MesaMapa_Mapa]
    FOREIGN KEY ([Mapas_Id])
    REFERENCES [dbo].[MapaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaMapa_Mapa'
CREATE INDEX [IX_FK_MesaMapa_Mapa]
ON [dbo].[MesaMapa]
    ([Mapas_Id]);
GO

-- Creating foreign key on [Mestre_Id] in table 'MesaSet'
ALTER TABLE [dbo].[MesaSet]
ADD CONSTRAINT [FK_MesaMestre]
    FOREIGN KEY ([Mestre_Id])
    REFERENCES [dbo].[MestreSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaMestre'
CREATE INDEX [IX_FK_MesaMestre]
ON [dbo].[MesaSet]
    ([Mestre_Id]);
GO

-- Creating foreign key on [MesaId] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [FK_MesaJogador]
    FOREIGN KEY ([MesaId])
    REFERENCES [dbo].[MesaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MesaJogador'
CREATE INDEX [IX_FK_MesaJogador]
ON [dbo].[JogadorSet]
    ([MesaId]);
GO

-- Creating foreign key on [UsuarioId] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [FK_UsuarioJogador]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioJogador'
CREATE INDEX [IX_FK_UsuarioJogador]
ON [dbo].[JogadorSet]
    ([UsuarioId]);
GO

-- Creating foreign key on [MestreId] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_MestreFicha]
    FOREIGN KEY ([MestreId])
    REFERENCES [dbo].[MestreSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MestreFicha'
CREATE INDEX [IX_FK_MestreFicha]
ON [dbo].[FichaSet]
    ([MestreId]);
GO

-- Creating foreign key on [Ficha_Id] in table 'JogadorSet'
ALTER TABLE [dbo].[JogadorSet]
ADD CONSTRAINT [FK_JogadorFicha]
    FOREIGN KEY ([Ficha_Id])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JogadorFicha'
CREATE INDEX [IX_FK_JogadorFicha]
ON [dbo].[JogadorSet]
    ([Ficha_Id]);
GO

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

-- Creating foreign key on [Ficha_Id] in table 'VestimentaSet'
ALTER TABLE [dbo].[VestimentaSet]
ADD CONSTRAINT [FK_FichaVestimenta]
    FOREIGN KEY ([Ficha_Id])
    REFERENCES [dbo].[FichaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FichaVestimenta'
CREATE INDEX [IX_FK_FichaVestimenta]
ON [dbo].[VestimentaSet]
    ([Ficha_Id]);
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

-- Creating foreign key on [UsuarioId] in table 'MestreSet'
ALTER TABLE [dbo].[MestreSet]
ADD CONSTRAINT [FK_UsuarioMestre]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioMestre'
CREATE INDEX [IX_FK_UsuarioMestre]
ON [dbo].[MestreSet]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------