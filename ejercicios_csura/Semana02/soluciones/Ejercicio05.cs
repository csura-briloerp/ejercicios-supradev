using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio05 : IEjercicio
    {
        public void Ejecutar()
        {
            List<Persona> listaPersonas = new();
            listaPersonas.Add(new Persona("Carlos", 26));
            listaPersonas.Add(new Persona("Giovanny", 20));
            listaPersonas.Add(new Persona("Jorge", 33));

            foreach (Persona persona in listaPersonas)
            {
                persona.Saludar();
            }
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
