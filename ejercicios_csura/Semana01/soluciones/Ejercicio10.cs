using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio10 : IEjercicio
    {
        public void Ejecutar()
        {
            try
            {
                int numero = 0;
                bool es_numero_invalido = true;
                while (es_numero_invalido)
                {
                    Console.WriteLine("Ingrese un número entero positivo:");
                    numero = int.Parse(Console.ReadLine().Trim());

                    if (numero <= 0)
                    {
                        Console.WriteLine("Error: El número debe ser positivo y diferente de cero.\n");
                        continue;
                    }
                    else
                    {
                        es_numero_invalido = false;
                    }
                }

                int suma = 0;
                for (int i = 1; i <= numero; i++)
                {
                    suma += i;
                }

                Console.WriteLine($"\nLa suma de todos los números enteros desde 1 hasta {numero} es: {suma}");
            }
            catch
            {
                Console.WriteLine("Error: El valor ingresado debe ser un número entero válido.");
                return;
            }
        }
    }
}
