Public Class Ejercicio08
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Console.WriteLine("Resultado de Sub MostrarMensaje(mensaje As String):")
        MostrarMensaje("Este es un mensaje de prueba.")

        Console.WriteLine($"{vbCrLf}Resultado de Function SumarNumeros(a As Integer, b As Integer):")
        Console.WriteLine($"7 + 5 = {SumarNumeros(7, 5)}")
    End Sub

    Private Sub MostrarMensaje(mensaje As String)
        Console.WriteLine($"El mensaje a mostrar es: {mensaje}")
    End Sub

    Private Function SumarNumeros(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
End Class
