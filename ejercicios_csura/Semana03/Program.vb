Imports System
Imports Microsoft.VisualBasic

Module Program
    Sub Main(args As String())
        Do While True
            Try
                Console.Clear()
                Console.WriteLine("Digite el número de ejercicio para ejecutar la solución:")
                Dim ejercicio As Integer = Integer.Parse(Console.ReadLine().Trim())

                Select Case ejercicio
                    Case 1
                        EjecutarEjercicio(1, New Ejercicio01())
                        Exit Select
                    Case 2
                        EjecutarEjercicio(2, New Ejercicio02())
                        Exit Select
                    Case 3
                        EjecutarEjercicio(3, New Ejercicio03())
                        Exit Select
                    Case 4
                        EjecutarEjercicio(4, New Ejercicio04())
                        Exit Select
                    Case 5
                        EjecutarEjercicio(5, New Ejercicio05())
                        Exit Select
                    Case 6
                        EjecutarEjercicio(6, New Ejercicio06())
                        Exit Select
                    Case 7
                        EjecutarEjercicio(7, New Ejercicio07())
                        Exit Select
                    Case 8
                        EjecutarEjercicio(8, New Ejercicio08())
                        Exit Select
                    Case 9
                        EjecutarEjercicio(9, New Ejercicio09())
                        Exit Select
                    Case 10
                        EjecutarEjercicio(10, New Ejercicio10())
                        Exit Select
                    Case 11
                        EjecutarEjercicio(11, New Ejercicio11())
                        Exit Select
                    Case Else
                        Console.WriteLine($"{vbCrLf}Error: No existe el ejercicio {ejercicio}.")
                        Exit Select
                End Select

                Console.WriteLine("¿Desea continuar? (s/n)")
                Dim respuesta As String = Console.ReadLine().Trim().ToLower()
                Dim continuar As Char = If(String.IsNullOrEmpty(respuesta), "n", respuesta(0))

                If continuar <> "s" Then
                    Return
                End If
            Catch ex As Exception
                Console.WriteLine("Error: Ingrese un número entero. Presione cualquier tecla para continuar...")
                Console.ReadKey()
            End Try
        Loop
    End Sub

    Sub EjecutarEjercicio(numero As Integer, ejercicio As IEjercicio)
        Console.WriteLine($"{vbCrLf}--- Inicia ejecución del ejercicio {numero} ---{vbCrLf}")
        ejercicio.Ejecutar()
        Console.WriteLine($"{vbCrLf}--- Finaliza ejecución del ejercicio {numero} ---{vbCrLf}")
    End Sub
End Module
