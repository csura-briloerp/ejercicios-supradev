using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio08 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese el primer número: ");
                double primer_numero = double.Parse(Console.ReadLine().Trim());

                Console.WriteLine("Ingrese el segundo número: ");
                double segundo_numero = double.Parse(Console.ReadLine().Trim());

                if (primer_numero > segundo_numero)
                {
                    Console.WriteLine("\nEl primer número es mayor.");
                }
                else if (primer_numero < segundo_numero)
                {
                    Console.WriteLine("\nEl segundo número es mayor.");
                }
                else if (primer_numero == segundo_numero)
                {
                    Console.WriteLine("\nLos números son iguales.");
                }
            }
            catch
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número válido.");
                return;
            }
        }
    }
}
