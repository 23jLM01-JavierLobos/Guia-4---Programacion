using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Javier Lobos\n" + "Grado: IV bach - clave 17\n" + "====Tipos de Triangulos===");
        int opcion;

        Console.WriteLine("Ingrese el número de la lista:");
        Console.WriteLine("1. Carlos Méndez: 4123-5678");
        Console.WriteLine("2. Ana López: 5234-6789");
        Console.WriteLine("3. Luis Ramírez: 6345-7890");
        Console.WriteLine("4. María Castillo: 7456-8901");
        Console.WriteLine("5. Jorge Pérez: 8567-9012");
        Console.WriteLine("6. Sofía Herrera: 9678-0123");
        Console.WriteLine("7. Miguel Morales: 1789-1234");
        Console.WriteLine("8. Elena García: 2890-2345");
        Console.WriteLine("9. Ricardo Gómez: 3901-3456");
        Console.WriteLine("10. Valeria Ruiz: 4012-4567");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingeniero civil");
                break;
            case 2:
                Console.WriteLine("Diseñadora gráfica");
                break;
            case 3:
                Console.WriteLine("Profesor de matemáticas");
                break;
            case 4:
                Console.WriteLine("Arquitecta");
                break;
            case 5:
                Console.WriteLine("Desarrollador de software");
                break;
            case 6:
                Console.WriteLine("Contadora pública");
                break;
            case 7:
                Console.WriteLine("Técnico automotriz");
                break;
            case 8:
                Console.WriteLine("Fotógrafa profesional");
                break;
            case 9:
                Console.WriteLine("Médico general");
                break;
            case 10:
                Console.WriteLine("Veterinaria");
                break;
            default:
                Console.WriteLine("No se encuentra ese número.");
                break;
        }
    }
}
