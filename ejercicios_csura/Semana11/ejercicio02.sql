USE supradev;
GO

CREATE PROCEDURE usp_ObtenerPostsPorAutor
    @AutorId INT
AS
BEGIN
    SELECT titulo, contenido, fechaPublicacion
    FROM Posts
    WHERE AutorId = @AutorId
    ORDER BY fechaPublicacion DESC;
END;
GO

EXEC usp_ObtenerPostsPorAutor @AutorId = 1;
