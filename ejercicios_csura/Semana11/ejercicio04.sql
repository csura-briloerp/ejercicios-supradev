USE supradev;
GO

CREATE PROCEDURE usp_MarcarComentarioComoUtil
    @ComentarioId INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Comentarios WHERE Id = @ComentarioId)
    BEGIN
        UPDATE Comentarios
        SET texto = '[ÚTIL] ' + texto
        WHERE id = @ComentarioId AND texto NOT LIKE '[ÚTIL] %';
    END
    ELSE
    BEGIN
        PRINT 'Comentario no encontrado.';
    END
END;
GO

EXEC usp_MarcarComentarioComoUtil @ComentarioId = 5;

SELECT * FROM Comentarios WHERE id = 5;
