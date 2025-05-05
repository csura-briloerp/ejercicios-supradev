Public Class Ejercicio06
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Console.WriteLine("Números pares del 2 al 20:")
        For i As Integer = 2 To 20 Step 2
            Console.WriteLine(i)
        Next
    End Sub
End Class
