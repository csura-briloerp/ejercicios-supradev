<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio02
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
        Me.btnHazClic = New System.Windows.Forms.Button()
        Me.lblClic = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHazClic
        '
        Me.btnHazClic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHazClic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHazClic.Location = New System.Drawing.Point(12, 66)
        Me.btnHazClic.Name = "btnHazClic"
        Me.btnHazClic.Size = New System.Drawing.Size(220, 37)
        Me.btnHazClic.TabIndex = 0
        Me.btnHazClic.Text = "Haz Clic Aquí"
        Me.btnHazClic.UseVisualStyleBackColor = True
        '
        'lblClic
        '
        Me.lblClic.AutoSize = True
        Me.lblClic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClic.Location = New System.Drawing.Point(25, 24)
        Me.lblClic.Name = "lblClic"
        Me.lblClic.Size = New System.Drawing.Size(30, 25)
        Me.lblClic.TabIndex = 1
        Me.lblClic.Text = "..."
        '
        'Ejercicio02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 120)
        Me.Controls.Add(Me.lblClic)
        Me.Controls.Add(Me.btnHazClic)
        Me.Name = "Ejercicio02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHazClic As Button
    Friend WithEvents lblClic As Label
End Class
