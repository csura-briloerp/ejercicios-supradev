using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio04 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                Console.WriteLine("Ingrese su nombre:");
                string nombre = (Console.ReadLine()).Trim();

                Console.WriteLine("Ingrese su edad:");
                int edad = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"\nHola, {nombre}. Tienes {edad} años de edad.");
            }
            catch
            {
                Console.WriteLine("Error: Ingreso inválido. Asegúrese de ingresar un número entero para la edad.");
                return;
            }
        }
    }
}
