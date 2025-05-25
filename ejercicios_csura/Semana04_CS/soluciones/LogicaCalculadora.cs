using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana04_CS.soluciones
{
    internal class LogicaCalculadora
    {
        private Ejercicio03 cal;

        public LogicaCalculadora(Ejercicio03 form)
        {
            cal = form;
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

        public void ejecutarOperacion(string op)
        {
            try
            {
                if (!cal.esperandoNuevoNumero && !string.IsNullOrEmpty(cal.tboxPrincipal.Text))
                {
                    if (cal.operando1.HasValue && !string.IsNullOrEmpty(cal.operacion))
                    {
                        double operando2 = double.Parse(cal.tboxPrincipal.Text);
                        double resultado = realizarOperacion(cal.operando1.Value, operando2, cal.operacion);
                        if (resultado.ToString().Length > cal.anchoMaximo)
                        {
                            throw new Exception();
                        }
                        cal.operando1 = resultado;
                        cal.tboxPrincipal.Clear();
                        cal.agregarTexto(resultado.ToString());
                    }
                    else
                    {
                        cal.operando1 = double.Parse(cal.tboxPrincipal.Text);
                    }

                    if (op == "=")
                    {
                        cal.operacion = null;
                        cal.esperandoNuevoNumero = false;
                    }
                    else
                    {
                        cal.agregarTexto($" {op}");
                        cal.operacion = op;
                        cal.esperandoNuevoNumero = true;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                cal.tboxPrincipal.Text = "División entre cero.";
            }
            catch (Exception)
            {
                cal.tboxPrincipal.Text = "Error en operación.";
            }
        }
    }
}
