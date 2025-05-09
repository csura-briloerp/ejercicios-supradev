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
    public partial class Ejercicio01 : Form
    {
        public Ejercicio01()
        {
            InitializeComponent();
        }

        public bool btnPresionado = false;

        private void btnHazClic_Click(object sender, EventArgs e)
        {
            if (btnPresionado)
            {
                lblClic.Text = "...";
                lblClic.ForeColor = Color.Black;
                btnPresionado = false;
            }
            else
            {
                lblClic.Text = "¡Botón presionado!";
                lblClic.ForeColor = Color.Red;
                btnPresionado = true;
            }
        }
    }
}
