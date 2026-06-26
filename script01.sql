IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [TB_RESPONSAVEL] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Cpf] varchar(200) NOT NULL,
    [DataCadastro] datetime2 NOT NULL,
    [Endereco] varchar(200) NOT NULL,
    [TipoResponsavel] int NOT NULL,
    CONSTRAINT [PK_TB_RESPONSAVEL] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'DataCadastro', N'Endereco', N'Nome', N'TipoResponsavel') AND [object_id] = OBJECT_ID(N'[TB_RESPONSAVEL]'))
    SET IDENTITY_INSERT [TB_RESPONSAVEL] ON;
INSERT INTO [TB_RESPONSAVEL] ([Id], [Cpf], [DataCadastro], [Endereco], [Nome], [TipoResponsavel])
VALUES (1, '', '0001-01-01T00:00:00.0000000', '', '', 0),
(2, '', '0001-01-01T00:00:00.0000000', '', '', 0),
(3, '', '0001-01-01T00:00:00.0000000', '', '', 0),
(4, '', '0001-01-01T00:00:00.0000000', '', '', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'DataCadastro', N'Endereco', N'Nome', N'TipoResponsavel') AND [object_id] = OBJECT_ID(N'[TB_RESPONSAVEL]'))
    SET IDENTITY_INSERT [TB_RESPONSAVEL] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260626005012_InitialCreate', N'10.0.9');

COMMIT;
GO

