<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio05
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNuevaTarea = New System.Windows.Forms.Label()
        Me.tboxNuevaTarea = New System.Windows.Forms.TextBox()
        Me.btnAgregarTarea = New System.Windows.Forms.Button()
        Me.lboxTareas = New System.Windows.Forms.ListBox()
        Me.btnEliminarTarea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNuevaTarea
        '
        Me.lblNuevaTarea.AutoSize = True
        Me.lblNuevaTarea.Location = New System.Drawing.Point(13, 15)
        Me.lblNuevaTarea.Name = "lblNuevaTarea"
        Me.lblNuevaTarea.Size = New System.Drawing.Size(73, 13)
        Me.lblNuevaTarea.TabIndex = 0
        Me.lblNuevaTarea.Text = "Nueva Tarea:"
        '
        'tboxNuevaTarea
        '
        Me.tboxNuevaTarea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboxNuevaTarea.Location = New System.Drawing.Point(92, 12)
        Me.tboxNuevaTarea.Multiline = True
        Me.tboxNuevaTarea.Name = "tboxNuevaTarea"
        Me.tboxNuevaTarea.Size = New System.Drawing.Size(242, 60)
        Me.tboxNuevaTarea.TabIndex = 1
        '
        'btnAgregarTarea
        '
        Me.btnAgregarTarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarTarea.Location = New System.Drawing.Point(241, 78)
        Me.btnAgregarTarea.Name = "btnAgregarTarea"
        Me.btnAgregarTarea.Size = New System.Drawing.Size(93, 23)
        Me.btnAgregarTarea.TabIndex = 2
        Me.btnAgregarTarea.Text = "Agregar Tarea"
        Me.btnAgregarTarea.UseVisualStyleBackColor = True
        '
        'lboxTareas
        '
        Me.lboxTareas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lboxTareas.FormattingEnabled = True
        Me.lboxTareas.Location = New System.Drawing.Point(16, 107)
        Me.lboxTareas.Name = "lboxTareas"
        Me.lboxTareas.Size = New System.Drawing.Size(318, 329)
        Me.lboxTareas.TabIndex = 3
        '
        'btnEliminarTarea
        '
        Me.btnEliminarTarea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarTarea.Location = New System.Drawing.Point(16, 78)
        Me.btnEliminarTarea.Name = "btnEliminarTarea"
        Me.btnEliminarTarea.Size = New System.Drawing.Size(93, 23)
        Me.btnEliminarTarea.TabIndex = 4
        Me.btnEliminarTarea.Text = "Eliminar Tarea"
        Me.btnEliminarTarea.UseVisualStyleBackColor = True
        '
        'Ejercicio05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 450)
        Me.Controls.Add(Me.btnEliminarTarea)
        Me.Controls.Add(Me.lboxTareas)
        Me.Controls.Add(Me.btnAgregarTarea)
        Me.Controls.Add(Me.tboxNuevaTarea)
        Me.Controls.Add(Me.lblNuevaTarea)
        Me.Name = "Ejercicio05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio05"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNuevaTarea As Label
    Friend WithEvents tboxNuevaTarea As TextBox
    Friend WithEvents btnAgregarTarea As Button
    Friend WithEvents lboxTareas As ListBox
    Friend WithEvents btnEliminarTarea As Button
End Class
