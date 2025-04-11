using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio03 : IEjercicio
    {
        public void Ejecutar()
        {
            int a = 11;
            double b = 3.5;

            //Suma
            Console.WriteLine($"La suma de {a} + {b} es: {a + b}");

            //Resta
            Console.WriteLine($"La resta de {a} - {b} es: {a - b}");

            //Multiplicación
            Console.WriteLine($"La multiplicación de {a} * {b} es: {a * b}");

            //División
            Console.WriteLine($"La división de {a} / {b} es: {a / b}");
        }
    }
}
