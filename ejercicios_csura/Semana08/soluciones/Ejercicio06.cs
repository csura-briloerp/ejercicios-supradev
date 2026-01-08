using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana08.soluciones
{
    public partial class Ejercicio06 : Form, IEjercicio
    {
        public Ejercicio06()
        {
            InitializeComponent();
        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            lblPrincipal.ForeColor = Color.Orange;
            lblPrincipal.Text = "Procesando...";
            await Task.Delay(5000);
            lblPrincipal.Text = "Proceso completado.";
            lblPrincipal.ForeColor = Color.Green;
        }

        public async Task Ejecutar()
        {
            this.ShowDialog();
        }
    }
}
