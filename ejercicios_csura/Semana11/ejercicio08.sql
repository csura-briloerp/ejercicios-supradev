USE supradev;
GO

SELECT
    P.titulo AS PostTitulo,
    C.texto AS ComentarioTexto,
    C.fechaPublicacion,
    ROW_NUMBER() OVER(PARTITION BY C.postId ORDER BY C.fechaPublicacion ASC) AS NumeroComentarioEnPost
FROM Comentarios C
INNER JOIN Posts P ON C.postId = P.id
ORDER BY P.titulo, NumeroComentarioEnPost;
