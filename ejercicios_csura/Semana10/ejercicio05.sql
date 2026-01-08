--Seleccionar todos los autores.
SELECT * FROM Autores;

--Seleccionar solo el título y la fecha de publicación de todos los posts.
SELECT titulo, fechaPublicacion FROM Posts;

--Seleccionar los posts de la categoría 'Tecnología'.
SELECT *
FROM Posts
INNER JOIN Categorias ON Posts.categoriaId = Categorias.id
WHERE Categorias.nombre = 'Tecnología';

--Seleccionar los comentarios realizados por 'Carlos G.'.
SELECT * FROM Comentarios WHERE autorNombre = 'Carlos G.';

--Seleccionar los posts publicados después de una fecha específica.
SELECT * FROM Posts WHERE fechaPublicacion > '2023-01-01';

--Seleccionar los posts cuyo título contenga la palabra 'SQL'.
SELECT * FROM Posts WHERE titulo LIKE '%SQL%';
