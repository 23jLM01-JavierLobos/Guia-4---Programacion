
using System;

class Program
{
    static void Main()
    {
        double l1, l2, l3;

        Console.Write("Ingrese la medida del lado 1: ");
        l1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la medida del lado 2: ");
        l2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la medida del lado 3: ");
        l3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si puede formar un triángulo
        if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
        {
            if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("El triángulo es: EQUILÁTERO");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("El triángulo es: ISÓSCELES");
            }
            else
            {
                Console.WriteLine("El triángulo es: ESCALENO");
            }
        }
        else
        {
            Console.WriteLine("Error: Las medidas ingresadas no pueden formar un triángulo.");
        }
    }
}
