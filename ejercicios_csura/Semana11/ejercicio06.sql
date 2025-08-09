USE supradev;
GO

SELECT nombre, email
FROM Autores
WHERE id IN (
    SELECT DISTINCT autorId
    FROM Posts P
    INNER JOIN Categorias Cat ON P.categoriaId = Cat.id
    WHERE Cat.nombre = 'Tecnología'
);
