using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio03 : IEjercicio
    {
        public void Ejecutar()
        {
            Persona persona = new("Isaí", -25);
            persona.Saludar();
        }

        private class Persona
        {
            private string Nombre;
            private int edad;

            public int Edad
            {
                get { return edad; }
                set
                {
                    if (value < 0)
                    {
                        edad = 0;
                    }
                    else
                    {
                        edad = value;
                    }
                }
            }

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
