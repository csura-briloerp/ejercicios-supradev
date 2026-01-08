IF NOT EXISTS (SELECT * FROM master.sys.databases WHERE [name] = 'supradev')
BEGIN
	CREATE DATABASE supradev;
END;
GO

USE supradev;
GO

CREATE TABLE Autores (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Categorias (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Posts (
    id INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(1000) NOT NULL,
    contenido VARCHAR(MAX) NOT NULL,
    fechaPublicacion DATETIME NOT NULL,
    autorId INT NOT NULL CONSTRAINT fk_posts_autores FOREIGN KEY REFERENCES Autores(id),
    categoriaId INT NOT NULL CONSTRAINT fk_posts_categorias FOREIGN KEY REFERENCES Categorias(id)
)
GO

CREATE TABLE Comentarios (
    id INT IDENTITY(1,1) PRIMARY KEY,
    texto VARCHAR(MAX) NOT NULL,
    fechaPublicacion DATETIME NOT NULL,
    autorNombre VARCHAR(100) NOT NULL,
    postId INT NOT NULL CONSTRAINT fk_comentarios_posts FOREIGN KEY REFERENCES Posts(id)
)
GO
