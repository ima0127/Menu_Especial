-- 1. Borrar la base de datos si existe
IF DB_ID('menuUsuarios') IS NOT NULL
    DROP DATABASE menuUsuarios;
GO

-- 2. Crear la base de datos
CREATE DATABASE menuUsuarios;
GO

-- 3. Usar la base de datos recién creada
USE menuUsuarios;
GO

-- 4. Crear la tabla si no existe
IF OBJECT_ID('Usuarios', 'U') IS NULL
BEGIN
    CREATE TABLE Usuarios (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Usuario NVARCHAR(50) NOT NULL UNIQUE,
        Contrasena NVARCHAR(255) NOT NULL
    );
END
GO

-- 5. Insertar usuario de prueba si no existe
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Usuario='admin')
BEGIN
    INSERT INTO Usuarios (Usuario, Contrasena) VALUES ('admin', '1234');
END
GO
