using Semana08.soluciones;

while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Digite el número de ejercicio para ejecutar la solución:");
        int ejercicio = int.Parse(Console.ReadLine().Trim());

        switch (ejercicio)
        {
            case 1:
                await EjecutarEjericio(1, new Ejercicio01());
                break;
            case 2:
                await EjecutarEjericio(2, new Ejercicio02());
                break;
            case 3:
                await EjecutarEjericio(3, new Ejercicio03());
                break;
            case 4:
                Console.WriteLine("Para revisar el ejercicio 4 debe ejecutar el proyecto WebAI \"Semana08_API\".\n");
                break;
            case 5:
                await EjecutarEjericio(5, new Ejercicio05());
                break;
            case 6:
                await EjecutarEjericio(6, new Ejercicio06());
                break;
            default:
                Console.WriteLine($"\nError: No existe el ejercicio {ejercicio}.");
                break;
        }

        Console.WriteLine("¿Desea continuar? (s/n)");
        string respuesta = Console.ReadLine().Trim().ToLower();
        char continuar = string.IsNullOrEmpty(respuesta) ? 'n' : respuesta[0];
        if (continuar != 's')
        {
            break;
        }
    }
    catch
    {
        Console.WriteLine("Error: Ingrese un número entero. Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}

async Task EjecutarEjericio(int numero, IEjercicio ejercicio)
{
    Console.WriteLine($"\n--- Inicia ejecución del ejercicio {numero} ---\n");
    await ejercicio.Ejecutar();
    Console.WriteLine($"\n--- Finaliza ejecución del ejercicio {numero} ---\n");
}
