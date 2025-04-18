using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio08 : IEjercicio
    {
        public void Ejecutar()
        {
            while (true)
            {
                Console.WriteLine("\nIngrese qué operación desea realizar:" +
                "\n- 's' para sumar" +
                "\n- 'r' para restar" +
                "\n- 'm' para multiplicar" +
                "\n- 'd' para dividir");
                string entrada = Console.ReadLine().ToString().ToLower();
                char operacion = string.IsNullOrEmpty(entrada) ? 'n' : entrada[0];

                ArrayList operaciones_validas = new() { 's', 'r', 'm', 'd' };
                if (!operaciones_validas.Contains(operacion))
                {
                    Console.WriteLine("Operación no válida.");
                    continue;
                }

                double a, b;
                try
                {
                    Console.WriteLine("\nIngrese el primer número:");
                    a = double.Parse(Console.ReadLine().ToString());

                    Console.WriteLine("\nIngrese el segundo número:");
                    b = double.Parse(Console.ReadLine().ToString());
                }
                catch
                {
                    Console.WriteLine("Ingrese un número válido para poder operar.");
                    continue;
                }

                if (b == 0 && operacion == 'd')
                {
                    Console.WriteLine("Error: no se puede dividir entre 0.");
                    continue;
                }

                Console.WriteLine();
                switch (operacion)
                {
                    case 's':
                        Console.WriteLine($"Suma {a} + {b}: {Calculadora.Sumar(a, b)}");
                        break;
                    case 'r':
                        Console.WriteLine($"Resta {a} - {b}: {Calculadora.Restar(a, b)}");
                        break;
                    case 'm':
                        Console.WriteLine($"Multiplicación {a} * {b}: {Calculadora.Multiplicar(a, b)}");
                        break;
                    case 'd':
                        Console.WriteLine($"División {a} / {b}: {Calculadora.Dividir(a, b)}");
                        break;
                }

                Console.WriteLine("\n¿Desea realizar otra operación? (s/n)");
                string respuesta = Console.ReadLine().Trim().ToLower();
                char continuar = string.IsNullOrEmpty(respuesta) ? 'n' : respuesta[0];
                if (continuar != 's')
                {
                    break;
                }
            }
        }

        private class Calculadora
        {

            public static double Sumar(double a, double b)
            {
                return Math.Round(a + b, 2);
            }

            public static double Restar(double a, double b)
            {
                return Math.Round(a - b, 2);
            }

            public static double Multiplicar(double a, double b)
            {
                return Math.Round(a * b, 2);
            }

            public static double Dividir(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return 0;
                }
                return Math.Round(a / b, 2);
            }
        }
    }
}
