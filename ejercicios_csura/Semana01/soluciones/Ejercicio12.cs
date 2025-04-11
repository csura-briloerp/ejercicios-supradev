using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio12 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                int numero = 0;
                bool es_numero_invalido = true;
                while (es_numero_invalido)
                {
                    Console.WriteLine("Adivina el número entero secreto entre 1 y 10:");
                    numero = int.Parse(Console.ReadLine().Trim());

                    if (numero < 1 || numero > 10)
                    {
                        Console.WriteLine("Error: El número debe ser un entero entre 1 y 10.\n");
                        continue;
                    }
                    else if (numero != 7)
                    {
                        Console.WriteLine("No has adivinado, intenta de nuevo.\n");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n¡Felicidades! Has adivinado el número secreto.");
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
