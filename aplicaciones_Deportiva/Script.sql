/*
CREATE DATABASE db_Deportiva;
GO
USE db_Deportiva;
GO

CREATE TABLE [Auditorias] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Descripcion] NVARCHAR(250) NOT NULL,
    [Fecha] SMALLDATETIME NOT NULL
);

CREATE TABLE [Tipos] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Marca] NVARCHAR(250) NOT NULL,
    [Categoria] NVARCHAR(250) NOT NULL
);

CREATE TABLE [Balones] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Codigo] NVARCHAR(20) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Tamaño] DECIMAL(18, 2) NOT NULL,
    [Activa] BIT NOT NULL,
    [Id_Tipo] INT NOT NULL REFERENCES [Tipos]([Id])
);


INSERT INTO Tipos (Marca, Categoria) VALUES ('Sharp', 'Volei'), ('Perse', 'ruby');
SELECT * FROM Tipos;

INSERT INTO Balones (Codigo, Nombre, Tamaño, Activa, Id_Tipo) VALUES ('C002', 'arpen', 1.80, 1, 2);


select * from Tipos, Balones
*/