USE supradev;
GO

CREATE PROCEDURE usp_AgregarAutor
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Autores (nombre, email)
    VALUES (@Nombre, @Email);
END;
GO

EXEC usp_AgregarAutor @Nombre = 'Laura Gómez', @Email = 'laura.gomez@email.com';

SELECT * FROM Autores;
