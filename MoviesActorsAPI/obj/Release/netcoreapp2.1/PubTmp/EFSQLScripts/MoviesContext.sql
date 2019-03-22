IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190305203810_InitialCreate')
BEGIN
    CREATE TABLE [Movie] (
        [Name] nvarchar(450) NOT NULL,
        [ReleaseYear] int NOT NULL,
        [Genre] nvarchar(max) NOT NULL,
        [Stars] int NOT NULL,
        [Runtime] int NOT NULL,
        CONSTRAINT [PK_Movie] PRIMARY KEY ([Name])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190305203810_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190305203810_InitialCreate', N'2.1.4-rtm-31024');
END;

GO

