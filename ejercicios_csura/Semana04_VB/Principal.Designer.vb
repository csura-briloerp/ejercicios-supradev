<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btnEjercicio02 = New System.Windows.Forms.Button()
        Me.btnEjercicio05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEjercicio02
        '
        Me.btnEjercicio02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEjercicio02.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjercicio02.Location = New System.Drawing.Point(12, 12)
        Me.btnEjercicio02.Name = "btnEjercicio02"
        Me.btnEjercicio02.Size = New System.Drawing.Size(267, 39)
        Me.btnEjercicio02.TabIndex = 0
        Me.btnEjercicio02.Text = "Ejercicio 2"
        Me.btnEjercicio02.UseVisualStyleBackColor = True
        '
        'btnEjercicio05
        '
        Me.btnEjercicio05.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEjercicio05.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjercicio05.Location = New System.Drawing.Point(12, 57)
        Me.btnEjercicio05.Name = "btnEjercicio05"
        Me.btnEjercicio05.Size = New System.Drawing.Size(267, 39)
        Me.btnEjercicio05.TabIndex = 1
        Me.btnEjercicio05.Text = "Ejercicio 5"
        Me.btnEjercicio05.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 450)
        Me.Controls.Add(Me.btnEjercicio05)
        Me.Controls.Add(Me.btnEjercicio02)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semana 4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEjercicio02 As Button
    Friend WithEvents btnEjercicio05 As Button
End Class
