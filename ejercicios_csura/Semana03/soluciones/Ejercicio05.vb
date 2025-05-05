Public Class Ejercicio05
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Dim numero As Integer = 0
        Dim numeroValido As Boolean = False

        Do While Not numeroValido
            Try
                Console.WriteLine("Ingrese un número entero:")
                numero = CInt(Console.ReadLine().Trim())
            Catch
                Console.WriteLine($"Error: Ingrese un número entero válido.{vbCrLf}")
                Continue Do
            End Try

            numeroValido = True
        Loop

        Console.WriteLine($"{vbCrLf}El número {numero} es {If(numero Mod 2 = 0, "par", "impar")}.")
    End Sub
End Class
