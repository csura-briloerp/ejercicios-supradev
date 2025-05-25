Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Ejercicio05
    Private Sub btnAgregarTarea_Click(sender As Object, e As EventArgs) Handles btnAgregarTarea.Click
        Dim nuevaTarea As String = tboxNuevaTarea.Text.Trim()
        If String.IsNullOrEmpty(nuevaTarea) Then
            MessageBox.Show("Por favor, ingrese una tarea.")
            Return
        End If
        lboxTareas.Items.Add("- " + nuevaTarea)
        actualizarCatidadDeTareas()
        tboxNuevaTarea.Clear()
        tboxNuevaTarea.Focus()
    End Sub

    Private Sub Ejercicio05_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lboxTareas.Items.Add("Tareas:")
    End Sub

    Private Sub btnEliminarTarea_Click(sender As Object, e As EventArgs) Handles btnEliminarTarea.Click
        If MessageBox.Show(Nothing, "¿Seguro que quiere eliminar la tarea?", "Eliminar tarea.", MessageBoxButtons.YesNo) = vbYes Then
            If lboxTareas.SelectedIndex > 0 Then
                lboxTareas.Items.RemoveAt(lboxTareas.SelectedIndex)
                actualizarCatidadDeTareas()
            Else
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.")
            End If
        End If
    End Sub

    Private Sub actualizarCatidadDeTareas()
        lboxTareas.Items(0) = "Tareas (" + (lboxTareas.Items.Count - 1).ToString() + "):"
    End Sub
End Class