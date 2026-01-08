using System.Data.SqlClient;

string connectionString = "Server=.;Database=supradev;Trusted_Connection=True;";
int autorId = 1;

using (SqlConnection connection = new(connectionString))
{
    using (SqlCommand command = new("usp_ObtenerPostsPorAutor", connection))
    {
        command.CommandType = System.Data.CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@AutorId", autorId);

        connection.Open();
        using (SqlDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine($"Posts del autor {autorId}:");
            while (reader.Read())
            {
                Console.WriteLine($"- Título: {reader["Titulo"]}, Contenido: {reader["Contenido"]}");
            }
        }
    }
}
