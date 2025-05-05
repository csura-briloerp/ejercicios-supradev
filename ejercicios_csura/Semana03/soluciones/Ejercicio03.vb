Public Class Ejercicio03
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Dim nombre As String = ""
        Dim anioNacimiento As Integer
        Dim edadCalculada As Integer
        Dim datosValidos As Boolean = False

        Do While Not datosValidos
            nombre = ""
            anioNacimiento = 0
            edadCalculada = 0

            Try
                Console.WriteLine("Ingrese su nombre:")
                nombre = Console.ReadLine().Trim()
                If String.IsNullOrEmpty(nombre) Or String.IsNullOrWhiteSpace(nombre) Then
                    Throw New Exception
                End If
            Catch
                Console.WriteLine($"Error: Ingrese un nombre válido.{vbCrLf}")
                Continue Do
            End Try

            Try
                Console.WriteLine("Ingrese su año de nacimiento:")
                anioNacimiento = CInt(Console.ReadLine().Trim())
                edadCalculada = Date.Now.Year - anioNacimiento
                If edadCalculada <= 0 Or anioNacimiento <= 0 Then
                    Throw New Exception
                End If
            Catch
                Console.WriteLine($"Error: Ingrese un año de nacimiento válido.{vbCrLf}")
                Continue Do
            End Try

            datosValidos = True
        Loop

        Console.WriteLine($"{vbCrLf}Hola {nombre}, tienes aproximadamente {edadCalculada} años.")
    End Sub
End Class
