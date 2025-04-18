using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio04 : IEjercicio
    {
        public void Ejecutar()
        {
            Rectangulo rectangulo = new(5,6);
            Console.WriteLine($"El rectángulo tiene {rectangulo.Base} de base y {rectangulo.Altura} de altura.");
            Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()}");
            Console.WriteLine($"El perímetro del rectángulo es: {rectangulo.CalculaPerimetro()}");
        }

        private class Rectangulo
        {
            public double Base;
            public double Altura;

            public double CalcularArea()
            {
                return Base * Altura;
            }

            public double CalculaPerimetro()
            {
                return Base * 2 + Altura * 2;
            }

            public Rectangulo(double Base, double altura)
            {
                this.Base = Base;
                Altura = altura;
            }
        }
    }
}
