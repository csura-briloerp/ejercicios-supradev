using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio05 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                double a = double.Parse(Console.ReadLine().Trim());

                Console.WriteLine("Ingrese el segundo número:");
                double b = double.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"La suma de {a} + {b} es: {Math.Round((a + b), 2)}");
            }
            catch
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
                return;
            }
        }
    }
}
