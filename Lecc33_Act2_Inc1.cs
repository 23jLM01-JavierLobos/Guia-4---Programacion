internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Frase Invertida===");
        string f, fi;
        int lf;

        Console.Write("Ingrese una frase: ");
        f = Console.ReadLine();

        fi = "";
        lf = f.Length;

        for (int i = lf - 1; i >= 0; i--)
        {

            fi = fi + f[i];
        }

        Console.WriteLine($"La frase invertida es: {fi}");


    }
}
