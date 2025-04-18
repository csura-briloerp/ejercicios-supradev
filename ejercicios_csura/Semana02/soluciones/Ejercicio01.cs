using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio01 : IEjercicio
    {
        public void Ejecutar()
        {
            Persona persona = new();
            persona.Saludar();
        }

        private class Persona
        {
            private string Nombre = "Carlos";
            private int Edad = 26;

            public void Saludar()
            {
                Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
            }
        }
    }
}
