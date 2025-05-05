Imports System.Windows.Forms

Public Class Ejercicio11
    Implements IEjercicio

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.OK
        Close
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        MsgBox("¡Haz hecho clic!", MsgBoxStyle.Information, "Ejercicio 11")
    End Sub

    Sub Ejecutar() Implements IEjercicio.Ejecutar
        Console.WriteLine("Ejecutando Ejercicio 11...")
        Me.ShowDialog()
    End Sub
End Class
