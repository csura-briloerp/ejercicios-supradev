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
    public partial class Ejercicio03 : Form
    {
        private LogicaCalculadora logica;
        public Ejercicio03()
        {
            InitializeComponent();
            logica = new LogicaCalculadora(this);
        }

        public double? operando1 = null;
        public string operacion = null;
        public bool esperandoNuevoNumero = false;
        public int anchoMaximo = 16;

        public void agregarTexto(string texto)
        {
            if (tboxPrincipal.Text.Length + texto.Length <= anchoMaximo)
            {
                if (esperandoNuevoNumero)
                {
                    tboxPrincipal.Clear();
                    esperandoNuevoNumero = false;
                }
                tboxPrincipal.Text += texto;
            }
            else
            {
                tboxPrincipal.Text = "Muy extenso.";
                operando1 = null;
                operacion = null;
                esperandoNuevoNumero = true;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!tboxPrincipal.Text.Contains("."))
            {
                agregarTexto(".");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            agregarTexto("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            agregarTexto("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            agregarTexto("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            agregarTexto("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            agregarTexto("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            agregarTexto("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            agregarTexto("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            agregarTexto("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            agregarTexto("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            agregarTexto("9");
        }      

        private void btnPlus_Click(object sender, EventArgs e)
        {
            logica.ejecutarOperacion("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            logica.ejecutarOperacion("-");
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            logica.ejecutarOperacion("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            logica.ejecutarOperacion("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            logica.ejecutarOperacion("=");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxPrincipal.Clear();
            operando1 = null;
            operacion = null;
            esperandoNuevoNumero = false;
        }
    }
}
