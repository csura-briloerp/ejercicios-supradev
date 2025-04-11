using Semana01.soluciones;
using System.Diagnostics.CodeAnalysis;

namespace soluciones
{
    public class Ejercicio14 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                int cantidad_de_notas = 0;
                bool es_numero_invalido = true;
                while (es_numero_invalido)
                {
                    Console.WriteLine("Ingrese la cantidad de notas que desa promediar:");
                    cantidad_de_notas = int.Parse(Console.ReadLine().Trim());

                    if (cantidad_de_notas < 1)
                    {
                        Console.WriteLine("Error: El número debe ser un entero positivo.\n");
                        continue;
                    }
                    else
                    {
                        es_numero_invalido = false;
                    }
                }

                Console.WriteLine();
                double suma = 0;
                double promedio = 0;
                for (int i = 1; i <= cantidad_de_notas; i++)
                {
                    Console.Write($"Ingrese la nota {i}: ");
                    double nota = double.Parse(Console.ReadLine().Trim());
                    suma += nota;
                }

                promedio = suma / cantidad_de_notas;
                Console.WriteLine($"\nEl promedio de las {cantidad_de_notas} notas ingresadas es: {Math.Round(promedio, 2)}");
            }
            catch
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número válido.");
                return;
            }
        }
    }
}
