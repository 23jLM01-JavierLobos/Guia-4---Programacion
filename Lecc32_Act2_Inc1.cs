internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Horoscopo===");
        int mes, dia;

        Console.Write("Ingrese su mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(); 

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            Console.WriteLine("Su signo es Aries");
            Console.WriteLine("Su horoscopo es que usted sera Inventor");
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            Console.WriteLine("Su signo es Tauro");
            Console.WriteLine("Su horoscopo es de que usted sera Artista");
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            Console.WriteLine("Su signo es Geminis");
            Console.WriteLine("Su horoscopo es de que usted sera Musico");
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            Console.WriteLine("Su signo es Cancer");
            Console.WriteLine("Su horoscopo es de que usted sera Millonario");
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            Console.WriteLine("Su signo es Leo");
            Console.WriteLine("Su horoscopo es de que usted sera Famoso ");
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            Console.WriteLine("Su signo es Virgo");
            Console.WriteLine("Su horoscopo es de que usted sera Cocinero");
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            Console.WriteLine("Su signo es Libra");
            Console.WriteLine("Su horoscopo es de que usted sera Sacerdote");
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            Console.WriteLine("Su signo es Escorpio");
            Console.WriteLine("Su horoscopo es de que usted sera Maestro");
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            Console.WriteLine("Su signo es Sagitario");
            Console.WriteLine("Su horoscopo es de que usted sera Ingeniero");
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            Console.WriteLine("Su signo es Capricornio");
            Console.WriteLine("Su horoscopo es de que usted sera Licenciado");
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            Console.WriteLine("Su signo es Acuario");
            Console.WriteLine("Su horoscopo es de que usted sera Abogado");
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            Console.WriteLine("Su signo es Piscis");
            Console.WriteLine("Su horoscopo es de que usted sera Mecanico");
        }
        else
        {
            Console.WriteLine("Signo no registrado");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}