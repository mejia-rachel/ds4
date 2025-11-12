CREATE DATABASE ConversorDB;
GO

USE ConversorDB;
GO

CREATE TABLE Historial (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TipoConversion NVARCHAR(50),
    ValorEntrada NVARCHAR(50),
    Resultado NVARCHAR(50),
    Fecha DATETIME DEFAULT GETDATE()
);
