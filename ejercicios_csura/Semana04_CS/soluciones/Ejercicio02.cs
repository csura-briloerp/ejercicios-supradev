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

        private double? operando1 = null;
        private string operacion = null;
        private bool esperandoNuevoNumero = false;
        private int anchoMaximo = 16;

        private void agregarTexto(string texto)
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

        private double realizarOperacion(double a, double b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b != 0)
                        return a / b;
                    else
                        throw new DivideByZeroException();
                default:
                    return 0;
            }
        }

        private void ejecutarOperacion(string op)
        {
            try
            {
                if (!esperandoNuevoNumero && !string.IsNullOrEmpty(tboxPrincipal.Text))
                {
                    if (operando1.HasValue && !string.IsNullOrEmpty(operacion))
                    {
                        double operando2 = double.Parse(tboxPrincipal.Text);
                        double resultado = realizarOperacion(operando1.Value, operando2, operacion);
                        if (resultado.ToString().Length > anchoMaximo)
                        {
                            throw new Exception();
                        }
                        operando1 = resultado;
                        tboxPrincipal.Clear();
                        agregarTexto(resultado.ToString());
                    }
                    else
                    {
                        operando1 = double.Parse(tboxPrincipal.Text);
                    }

                    if (op == "=")
                    {
                        operacion = null;
                        esperandoNuevoNumero = false;
                    }
                    else
                    {
                        agregarTexto($" {op}");
                        operacion = op;
                        esperandoNuevoNumero = true;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                tboxPrincipal.Text = "División entre cero.";
            }
            catch (Exception)
            {
                tboxPrincipal.Text = "Error en operación.";
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
            ejecutarOperacion("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ejecutarOperacion("-");
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            ejecutarOperacion("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ejecutarOperacion("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            ejecutarOperacion("=");
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
