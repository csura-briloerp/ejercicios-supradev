using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana04_CS.soluciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnEjercicio01_Click(object sender, EventArgs e)
        {
            Form ejercicio01 = new Ejercicio01();
            ejercicio01.ShowDialog();
        }

        private void btnEjercicio03_Click(object sender, EventArgs e)
        {
            Form ejercicio03 = new Ejercicio03();
            ejercicio03.ShowDialog();
        }
    }
}
