using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana08.soluciones
{
    internal class Ejercicio02 : IEjercicio
    {
        public async Task Ejecutar()
        {
            async Task<string> ObtenerDatosAsync()
            {
                await Task.Delay(2000);
                return "Datos obtenidos exitosamente.";
            }

            string resultado = await ObtenerDatosAsync();
            Console.WriteLine(resultado);
        }
    }
}
