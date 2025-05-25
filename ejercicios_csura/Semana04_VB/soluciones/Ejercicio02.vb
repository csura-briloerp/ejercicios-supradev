Public Class Ejercicio02
    Dim btnPrsionado As Boolean = False
    Private Sub btnHazClic_Click(sender As Object, e As EventArgs) Handles btnHazClic.Click
        If btnPrsionado Then
            lblClic.Text = "..."
            lblClic.ForeColor = Color.Black
            btnPrsionado = False
        Else
            lblClic.Text = "¡Botón presionado!"
            lblClic.ForeColor = Color.Red
            btnPrsionado = True
        End If
    End Sub
End Class