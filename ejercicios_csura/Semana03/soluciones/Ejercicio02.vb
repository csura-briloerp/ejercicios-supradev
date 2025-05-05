Public Class Ejercicio02
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Dim entero As Integer = 2
        Dim fraccion As Double = 3.1416
        Dim cadena As String = "Cadena de texto"
        Dim booleano As Boolean = True
        Dim fecha As Date = Date.Now

        Console.WriteLine("El valor de variable tipo entera es: " & entero)
        Console.WriteLine("El valor de variable tipo fraccionaria es: " & fraccion)
        Console.WriteLine("El valor de variable tipo cadena es: " & cadena)
        Console.WriteLine("El valor de variable tipo booleana es: " & booleano)
        Console.WriteLine("El valor de variable tipo fecha es: " & fecha.Date)
    End Sub
End Class
