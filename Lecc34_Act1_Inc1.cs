internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Retos===");
        int nd, r;
        string b;

        Console.Write("Digite un numero decimal: ");
        nd = Convert.ToInt32(Console.ReadLine());

        b = "";

        if (nd == 0)
        {
            b = "0";
        }
        else
        {
            while (nd > 0)
            {
                r = nd % 2; 

                b = r.ToString() + b;

 
                nd = nd / 2;
            }
        }

        Console.WriteLine($"El numero en binario es: {b}");
    }
}
