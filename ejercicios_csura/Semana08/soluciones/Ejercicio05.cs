using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana08.soluciones
{
    internal class Ejercicio05 : IEjercicio
    {
        public async Task Ejecutar()
        {
            async Task LanzarExcepcionAsync()
            {
                await Task.Delay(1000);
                throw new InvalidOperationException();
            }

            try
            {
                await LanzarExcepcionAsync();
            }
            catch
            {
                Console.WriteLine("Mensaje de error asíncrono.");
            }
        }
    }
}
