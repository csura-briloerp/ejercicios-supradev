namespace Semana04_CS.soluciones
{
    partial class Ejercicio01
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
            this.btnHazClic = new System.Windows.Forms.Button();
            this.lblClic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHazClic
            // 
            this.btnHazClic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHazClic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHazClic.Location = new System.Drawing.Point(12, 61);
            this.btnHazClic.Name = "btnHazClic";
            this.btnHazClic.Size = new System.Drawing.Size(218, 38);
            this.btnHazClic.TabIndex = 0;
            this.btnHazClic.Text = "Haz Clic Aquí";
            this.btnHazClic.UseVisualStyleBackColor = true;
            this.btnHazClic.Click += new System.EventHandler(this.btnHazClic_Click);
            // 
            // lblClic
            // 
            this.lblClic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClic.AutoSize = true;
            this.lblClic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClic.Location = new System.Drawing.Point(25, 19);
            this.lblClic.Name = "lblClic";
            this.lblClic.Size = new System.Drawing.Size(30, 25);
            this.lblClic.TabIndex = 1;
            this.lblClic.Text = "...";
            // 
            // Ejercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 112);
            this.Controls.Add(this.lblClic);
            this.Controls.Add(this.btnHazClic);
            this.Name = "Ejercicio01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHazClic;
        private System.Windows.Forms.Label lblClic;
    }
}