USE supradev;
GO

ALTER PROCEDURE usp_AgregarAutor
    @Nombre NVARCHAR(100),
    @Email NVARCHAR(100),
    @NuevoAutorId INT OUTPUT
AS
BEGIN
    INSERT INTO Autores (Nombre, Email)
    VALUES (@Nombre, @Email);

    SET @NuevoAutorId = SCOPE_IDENTITY();
END;
GO

DECLARE @IdGenerado INT;
EXEC usp_AgregarAutor @Nombre = 'Mario Bros', @Email = 'mario@nintendo.com', @NuevoAutorId = @IdGenerado OUTPUT;
SELECT @IdGenerado AS IdDelNuevoAutor;
