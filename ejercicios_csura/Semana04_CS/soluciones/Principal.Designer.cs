namespace Semana04_CS.soluciones
{
    partial class Principal
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
            this.btnEjercicio01 = new System.Windows.Forms.Button();
            this.btnEjercicio02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjercicio01
            // 
            this.btnEjercicio01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjercicio01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio01.Location = new System.Drawing.Point(12, 12);
            this.btnEjercicio01.Name = "btnEjercicio01";
            this.btnEjercicio01.Size = new System.Drawing.Size(251, 40);
            this.btnEjercicio01.TabIndex = 0;
            this.btnEjercicio01.Text = "Ejercicio 1";
            this.btnEjercicio01.UseVisualStyleBackColor = true;
            this.btnEjercicio01.Click += new System.EventHandler(this.btnEjercicio01_Click);
            // 
            // btnEjercicio02
            // 
            this.btnEjercicio02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjercicio02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio02.Location = new System.Drawing.Point(12, 58);
            this.btnEjercicio02.Name = "btnEjercicio02";
            this.btnEjercicio02.Size = new System.Drawing.Size(251, 40);
            this.btnEjercicio02.TabIndex = 1;
            this.btnEjercicio02.Text = "Ejercicio 2";
            this.btnEjercicio02.UseVisualStyleBackColor = true;
            this.btnEjercicio02.Click += new System.EventHandler(this.btnEjercicio02_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.btnEjercicio02);
            this.Controls.Add(this.btnEjercicio01);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semana 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio01;
        private System.Windows.Forms.Button btnEjercicio02;
    }
}