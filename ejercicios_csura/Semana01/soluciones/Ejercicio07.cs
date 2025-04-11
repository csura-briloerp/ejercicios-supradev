using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio07 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese un número: ");
                double numero = double.Parse(Console.ReadLine().Trim());

                if (numero < 0)
                {
                    Console.WriteLine("\nEl número es negativo.");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("\nEl número es cero.");
                }
                else if (numero > 0)
                {
                    Console.WriteLine("\nEl número es positivo.");
                }
            }
            catch
            {
                System.Console.WriteLine("Error: El valor ingresado debe ser un número válido.");
                return;
            }
        }
    }
}
