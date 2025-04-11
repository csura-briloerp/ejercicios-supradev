using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio06 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese un número entero:");
                int numero = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"\nEl número {numero} es {(numero % 2 == 0 ? "par" : "impar")}.");
            }
            catch
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número entero.");
                return;
            }
        }
    }
}
