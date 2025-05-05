Public Class Ejercicio10
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Dim persona As Persona = New Persona()
        persona.Saludar()
    End Sub

    Private Class Persona
        Private Property nombre As String = "Carlos Sura"
        Private Property edad As Integer = 26

        Public Sub Saludar()
            Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.")
        End Sub
    End Class
End Class
