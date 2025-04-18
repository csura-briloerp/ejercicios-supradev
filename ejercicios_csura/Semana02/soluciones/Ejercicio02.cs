using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio02 : IEjercicio
    {
        public void Ejecutar()
        {
            Persona persona = new("Ana", 25);
            persona.Saludar();
        }

        private class Persona
        {
            private string Nombre;
            private int Edad;

            public void Saludar()
            {
                Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
            }

            public Persona(string nombre, int edad)
            {
                this.Nombre = nombre;
                this.Edad = edad;
            }
        }
    }
}
