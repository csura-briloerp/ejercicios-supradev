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
    public partial class Ejercicio02 : Form
    {
        public Ejercicio02()
        {
            InitializeComponent();
        }

        private bool operacionIniciada = false, operacionTerminada = false;
        private double operando1 = 0, operando2 = 0, resultado = 0;

        private void agregarTexto(string texto)
        {
            if (tboxPrincipal.Text.Length <= 15 && !operacionIniciada)
            {
                tboxPrincipal.Text += texto;
            }
            else if (operacionIniciada)
            {
                tboxPrincipal.Clear();
                tboxPrincipal.Text += texto;
                operacionIniciada = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            agregarTexto("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!tboxPrincipal.Text.Contains("."))
            {
                agregarTexto(".");
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxPrincipal.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (operacionTerminada)
            {
                try
                {
                    operando2 = Convert.ToDouble(tboxPrincipal.Text);
                    resultado = operando1 + operando2;
                    tboxPrincipal.Text = resultado.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la operación");
                }
            }
            else
            {
                try
                {
                    operando1 = Convert.ToDouble(tboxPrincipal.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la operación");
                }
                agregarTexto(" +");
                operacionIniciada = true;
            }
        }
    }
}
