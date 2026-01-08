using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana08.soluciones
{
    internal class Ejercicio03 : IEjercicio
    {
        public async Task Ejecutar()
        {
            async Task TareaAsync1()
            {
                Console.WriteLine("Iniciando tarea 1...");
                await Task.Delay(2000);
                Console.WriteLine("Se finalizó la tarea 1.");
            }
            async Task TareaAsync2()
            {
                Console.WriteLine("Iniciando tarea 2...");
                await Task.Delay(3000);
                Console.WriteLine("Se finalizó la tarea 2.");
            }

            Console.WriteLine("---Inicia ejecución secuencial---");
            await TareaAsync1();
            Console.WriteLine();
            await TareaAsync2();
            Console.WriteLine("---Finaliza ejecución secuencial---\n");

            Console.WriteLine("---Inicia ejecución concurrente---");
            await Task.WhenAll(TareaAsync1(), TareaAsync2());
            Console.WriteLine("---Finaliza ejecución concurrente---\n");
        }
    }
}
