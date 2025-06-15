namespace Semana08.soluciones
{
    partial class Ejercicio06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrincipal = new Label();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrincipal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrincipal.Location = new Point(10, 21);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(287, 40);
            lblPrincipal.TabIndex = 0;
            lblPrincipal.Text = "...";
            lblPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProcesar
            // 
            btnProcesar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProcesar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcesar.Location = new Point(12, 80);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(287, 40);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Ejercicio06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 132);
            Controls.Add(btnProcesar);
            Controls.Add(lblPrincipal);
            Name = "Ejercicio06";
            Text = "Ejercicio 6";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrincipal;
        private Button btnProcesar;
    }
}