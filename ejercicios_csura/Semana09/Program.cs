public interface IMensajero
{
    Task EnviarMensaje(string mensaje,string destinatario);
}

public class MensajeroConsola : IMensajero
{
    public async Task EnviarMensaje(string mensaje, string destinatario)
    {
        Console.WriteLine($"Enviando mensaje: '{mensaje}' a {destinatario}.");
        await Task.Delay(2000);
        Console.WriteLine($"Mensaje enviado correctamente a {destinatario}.");
    }
}

public class Procesador
{
    private readonly IMensajero _mensajero;
    public Procesador(IMensajero mensajero)
    {
        _mensajero = mensajero;
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        IMensajero mensajero = new MensajeroConsola();
        Procesador procesador = new Procesador(mensajero);
        await mensajero.EnviarMensaje("Hola, ¿cómo estás?", "Isaí");
        Console.WriteLine();
        await mensajero.EnviarMensaje("Reunión a las 3 PM", "Rodolfo");
    }
}
