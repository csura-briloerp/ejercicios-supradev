<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio11
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
        btnPrincipal = New Windows.Forms.Button()
        SuspendLayout()
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        btnPrincipal.Font = New System.Drawing.Font("Segoe UI", 15F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        btnPrincipal.Location = New System.Drawing.Point(12, 12)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New System.Drawing.Size(247, 98)
        btnPrincipal.TabIndex = 0
        btnPrincipal.Text = "Haz Clic"
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' Ejercicio11
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(271, 122)
        Controls.Add(btnPrincipal)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Ejercicio11"
        ShowInTaskbar = False
        StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        Text = "Ejercicio 11"
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrincipal As Windows.Forms.Button

End Class
