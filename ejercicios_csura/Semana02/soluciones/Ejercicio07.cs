using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio07 : IEjercicio
    {
        public void Ejecutar()
        {
            List<Persona> listaPersonas = new();
            listaPersonas.Add(new Persona("Carlos", 26));
            listaPersonas.Add(new Persona("Isaí", 29));
            listaPersonas.Add(new Persona("Giovanny", 20));
            listaPersonas.Add(new Estudiante("Vanessa", 29, "2023"));
            listaPersonas.Add(new Estudiante("Franco", 40, "2024"));
            listaPersonas.Add(new Estudiante("Rodolfo", 50, "2022"));

            foreach (var persona in listaPersonas)
            {
                persona.Saludar();
            }
        }

        private class Persona
        {
            protected string Nombre;
            protected int Edad;

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

        private class Estudiante : Persona
        {
            private string Matricula;
            public Estudiante(string nombre, int edad, string matricula) : base(nombre, edad)
            {
                this.Matricula = matricula;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Estudiante: {this.Nombre}\nEdad: {this.Edad}\nMatrícula: {this.Matricula}");
            }
        }
    }
}
