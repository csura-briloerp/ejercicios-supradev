using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio13 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                int edad = 0;
                bool es_numero_invalido = true;
                while (es_numero_invalido)
                {
                    Console.WriteLine("Ingresa una edad en años:");
                    edad = int.Parse(Console.ReadLine().Trim());

                    if (edad < 1)
                    {
                        Console.WriteLine("Error: La edad de ser un número entero positivo.\n");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"\nLa edad que ingresaste es: {edad} años");
                        es_numero_invalido = false;
                    }
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
