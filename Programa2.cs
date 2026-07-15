internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Calculadora de Cambio===");
        int pago;
        string producto;
        Console.Write("Digite el nombre producto:");
        producto = Console.ReadLine();
        Console.Write("Dame el precio del producto: ");
        int precio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el valor del billete: ");
        pago = Convert.ToInt32(Console.ReadLine());
        int cambio = pago - precio;
        Console.Write("Su cambio es: " + cambio);

    }
}