Public Class Ejercicio07
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Try
            Dim numero As Integer = 0
            Dim numeroInvalido As Boolean = True
            Do While numeroInvalido
                Console.WriteLine("Adivina el número entero secreto entre 1 y 10:")
                numero = CInt(Console.ReadLine().Trim())

                If numero < 1 Or numero > 10 Then
                    Console.WriteLine($"Error: El número debe ser un entero entre 1 y 10.{vbCrLf}")
                    Continue Do
                ElseIf numero <> 7 Then
                    Console.WriteLine($"No has adivinado, intenta de nuevo{vbCrLf}")
                    Continue Do
                Else
                    Console.WriteLine($"{vbCrLf}¡Felicidades! Has adivinado el número secreto.")
                    numeroInvalido = False
                End If
            Loop
        Catch
            Console.WriteLine("Error: El valor ingresado debe ser un número entero válido.")
        End Try
    End Sub
End Class
