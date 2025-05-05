Public Class Ejercicio04
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

        If numero < 0 Then
            Console.WriteLine("El número ingresado es negativo.")
        ElseIf numero = 0 Then
            Console.WriteLine("El número ingresado es cero.")
        Else
            Console.WriteLine("El número ingresado es positivo.")
        End If
    End Sub
End Class
