using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio11 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese un número entero para mostrar su tabla de multiplicar:");
                int numero = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"\nLa tabla del {numero} es:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
            catch
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número entero válido.");
                return;
            }
        }
    }
}
