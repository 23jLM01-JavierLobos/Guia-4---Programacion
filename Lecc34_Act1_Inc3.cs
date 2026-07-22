internal class Program
{
    private static void Main(string[] args)
    {
      Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Grados===");  
      double c, f, k;

        Console.Write("Ingrese la cantidad en grados centigrados: ");
        c = Convert.ToDouble(Console.ReadLine());

        f = (c * 1.8) + 32;
        k = c + 273.15;

        Console.WriteLine($"La cantidad de grados celsius es de: {c}");
        Console.WriteLine($"La cantidad de grados farhenheit es de: {f}");
        Console.WriteLine($"La cantidad de grados kelvin es de: {k}");
    }
}
