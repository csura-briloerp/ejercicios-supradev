using Semana01.soluciones;

namespace soluciones
{
    public class Ejercicio02 : IEjercicio
    {
        public void Ejecutar()
        {
            int edad = 26;
            Console.WriteLine($"Tengo {edad} años de edad.");

            double peso = 95.8;
            Console.WriteLine($"Mi peso actual es de {peso} kilos.");

            string nombre_completo = "Carlos Sura";
            Console.WriteLine($"Mi nombre completo es {nombre_completo}.");

            bool soy_implementador = true;
            Console.WriteLine(soy_implementador ? "Soy implementador" : "No soy implementador");

            char departamento = 'I';
            Console.WriteLine($"El código de mi departamento es {departamento}.");
        }
    }
}
