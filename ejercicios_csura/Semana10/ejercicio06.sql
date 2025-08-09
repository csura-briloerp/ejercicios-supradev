--Seleccionar el título del post y el nombre del autor para todos los posts (Posts INNER JOIN Autores).
SELECT P.titulo AS Post,
	   A.nombre AS Autor
FROM Posts P
INNER JOIN Autores A ON P.autorId = A.id;

--Seleccionar el título del post, el nombre de la categoría y el nombre del autor (Posts INNER JOIN Autores INNER JOIN Categorias).
SELECT P.titulo AS Post,
	   C.nombre AS Categoria,
	   A.nombre AS Autor
FROM Posts P
INNER JOIN Autores A ON P.autorId = A.id
INNER JOIN Categorias C ON C.id = P.categoriaId;

--Seleccionar todos los posts y sus comentarios. Incluye el título del post y el texto del comentario (Posts INNER JOIN Comentarios).
SELECT P.titulo AS Post,
	   C.texto AS Comentario
FROM Posts P
INNER JOIN Comentarios C ON C.postId = P.id;

--Seleccionar todos los autores y los títulos de los posts que han escrito. Incluye autores que no hayan escrito posts (Autores LEFT JOIN Posts).
INSERT INTO Autores (nombre, email) VALUES
('Test', 'test@email.com');

SELECT A.*,
	   P.titulo AS Post
FROM Autores A
LEFT JOIN Posts P ON P.autorId = A.id;
