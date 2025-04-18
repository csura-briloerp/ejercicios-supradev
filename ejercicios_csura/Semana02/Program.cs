using Semana02.soluciones;

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
                EjecutarEjericio(1, new Ejercicio01());
                break;
            case 2:
                EjecutarEjericio(2, new Ejercicio02());
                break;
            case 3:
                EjecutarEjericio(3, new Ejercicio03());
                break;
            case 4:
                EjecutarEjericio(4, new Ejercicio04());
                break;
            case 5:
                EjecutarEjericio(5, new Ejercicio05());
                break;
            case 6:
                EjecutarEjericio(6, new Ejercicio06());
                break;
            case 7:
                EjecutarEjericio(7, new Ejercicio07());
                break;
            case 8:
                EjecutarEjericio(8, new Ejercicio08());
                break;
            case 9:
                EjecutarEjericio(9, new Ejercicio09());
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

void EjecutarEjericio(int numero, IEjercicio ejercicio)
{
    Console.WriteLine($"\n--- Inicia ejecución del ejercicio {numero} ---\n");
    ejercicio.Ejecutar();
    Console.WriteLine($"\n--- Finaliza ejecución del ejercicio {numero} ---\n");
}
