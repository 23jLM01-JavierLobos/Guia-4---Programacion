using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Indice de Masa Corporal===");
        double peso, altura, imc;

        Console.Write("Ingrese su peso en kilogramos: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura en metros: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);

        Console.WriteLine("Su índice de masa corporal es: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Clasificación: Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Clasificación: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Clasificación: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Clasificación: Obesidad");
        }
    }
}
