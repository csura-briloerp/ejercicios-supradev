USE supradev;
GO

SELECT
    P.titulo,
    COUNT(C.id) AS NumeroDeComentarios
FROM Posts P
LEFT JOIN Comentarios C ON P.id = C.postId
GROUP BY P.id, P.titulo
ORDER BY NumeroDeComentarios DESC;
