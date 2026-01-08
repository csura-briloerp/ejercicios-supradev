INSERT INTO Autores (nombre, email) VALUES
('Carlos Sura', 'csura@email.com'),
('Isaí Álvarez', 'ialvarez@email.com');

INSERT INTO Categorias (nombre) VALUES
('Tecnología'),
('Videojuegos');

INSERT INTO Posts (titulo, contenido, fechaPublicacion, autorId, categoriaId) VALUES
('Introducción a SQL', 'Contenido sobre SQL...', GETDATE(), 1, 1),
('Donkey Kong Bananza', 'Contendiente a GOTY 2025...', GETDATE(), 2, 2),
('Novedades .NET 8', 'Resumen de features...', GETDATE(), 2, 1);

INSERT INTO Comentarios (texto, fechaPublicacion, autorNombre, postId) VALUES
('¡Muy útil!', GETDATE(), 'Carlos G.', 2),
('Gracias por el post.', GETDATE(), 'Maria R.', 2),
('¡Juegazo!', GETDATE(), 'Pedro M.', 3),
('Excelente resumen.', GETDATE(), 'Luisa F.', 4);
