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
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231229132308_InitialCreate')
BEGIN
    CREATE TABLE [Deliveries] (
        [DeliveryID] int NOT NULL IDENTITY,
        [Destination] nvarchar(max) NOT NULL,
        [ETA] nvarchar(max) NOT NULL,
        [Status] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Deliveries] PRIMARY KEY ([DeliveryID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20231229132308_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231229132308_InitialCreate', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101180544_CreateCargoTable')
BEGIN
    CREATE TABLE [Cargos] (
        [DeliveryID] int NOT NULL IDENTITY,
        [Destination] nvarchar(max) NOT NULL,
        [Quantity] int NOT NULL,
        [CargoId] int NOT NULL,
        CONSTRAINT [PK_Cargos] PRIMARY KEY ([DeliveryID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101180544_CreateCargoTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240101180544_CreateCargoTable', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101184515_UpdateCargoDatabase')
BEGIN
    ALTER TABLE [Cargos] DROP CONSTRAINT [PK_Cargos];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101184515_UpdateCargoDatabase')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cargos]') AND [c].[name] = N'CargoID');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Cargos] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Cargos] DROP COLUMN [CargoID];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101184515_UpdateCargoDatabase')
BEGIN
    ALTER TABLE [Cargos] ADD [CargoID] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101184515_UpdateCargoDatabase')
BEGIN
    ALTER TABLE [Cargos] ADD CONSTRAINT [PK_Cargos] PRIMARY KEY ([CargoID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101184515_UpdateCargoDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240101184515_UpdateCargoDatabase', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240101185511_Add-Migration FixCargoTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240101185511_Add-Migration FixCargoTable', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240102171300_CreateUserRevenueTables')
BEGIN
    CREATE TABLE [Revenue] (
        [RevenueID] int NOT NULL IDENTITY,
        [DeliveryID] int NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Month] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Revenue] PRIMARY KEY ([RevenueID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240102171300_CreateUserRevenueTables')
BEGIN
    CREATE TABLE [Users] (
        [UserID] int NOT NULL IDENTITY,
        [DeliveryID] int NOT NULL,
        [UserName] nvarchar(max) NOT NULL,
        [UserType] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240102171300_CreateUserRevenueTables')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240102171300_CreateUserRevenueTables', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'DeliveryID');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Users] DROP COLUMN [DeliveryID];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Revenue]') AND [c].[name] = N'DeliveryID');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Revenue] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Revenue] DROP COLUMN [DeliveryID];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    EXEC sp_rename N'[Users].[UserID]', N'UserId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    EXEC sp_rename N'[Revenue].[RevenueID]', N'RevenueId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    EXEC sp_rename N'[Deliveries].[DeliveryID]', N'DeliveryId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    EXEC sp_rename N'[Cargos].[DeliveryID]', N'DeliveryId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    EXEC sp_rename N'[Cargos].[CargoID]', N'CargoId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112193549_FinalMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240112193549_FinalMigration', N'7.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20240112204252_ConfigureIdentity')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240112204252_ConfigureIdentity', N'7.0.0');
END;
GO

COMMIT;
GO

