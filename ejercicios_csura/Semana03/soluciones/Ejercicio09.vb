Imports Microsoft.VisualBasic

Public Class Ejercicio09
    Implements IEjercicio

    Public Sub Ejecutar() Implements IEjercicio.Ejecutar
        Dim nombre As String = InputBox("Ingrese su nombre:", "Ejercicio 9")
        MsgBox($"Hola {nombre}", MsgBoxStyle.Information, "Ejercicio 9")
    End Sub
End Class
