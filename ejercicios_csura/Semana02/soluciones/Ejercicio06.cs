using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.soluciones
{
    internal class Ejercicio06 : IEjercicio
    {
        public void Ejecutar()
        {
            Estudiante estudiante = new("Carlos", 26, "Año 2023");
            estudiante.MostrarInformacion();
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
