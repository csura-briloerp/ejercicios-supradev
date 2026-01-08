using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana08.soluciones
{
    internal class Ejercicio01 : IEjercicio
    {
        public async Task Ejecutar()
        {
            async Task RealizarTareaLargaAsync()
            {
                Console.WriteLine("Iniciando tarea...");
                await Task.Delay(3000);
                Console.WriteLine("Tarea completada.");
            }

            await RealizarTareaLargaAsync();
        }
    }
}
