// See https://aka.ms/new-console-template for more information
using EspacionCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora nuevaCalc = new Calculadora();
        int opcion = 0;
        int numero = 0;
        while (opcion != 5)
        { // Cambia este número al número máximo de opciones en tu menú
            {
                Console.WriteLine();
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Selecciones el numero a Sumar");
                        if (!int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("Por favor, introduce un número válido.");
                            continue;
                        }
                        else
                        {
                            nuevaCalc.Sumar(numero);
                            Console.WriteLine();
                            Console.WriteLine($"Resultado: {nuevaCalc.Resultado}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Selecciones el numero a Restar");
                        if (!int.TryParse(Console.ReadLine(), out numero))
                        {

                            Console.WriteLine("Por favor, introduce un número válido.");
                            Console.WriteLine();

                            continue;
                        }
                        else
                        {
                            nuevaCalc.Restar(numero);
                            Console.WriteLine();
                            Console.WriteLine($"Resultado: {nuevaCalc.Resultado}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Selecciones el numero a Multiplicar");
                        if (!int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("Por favor, introduce un número válido.");
                            continue;
                        }
                        else
                        {
                            nuevaCalc.Multiplicar(numero);
                            Console.WriteLine();
                            Console.WriteLine($"Resultado: {nuevaCalc.Resultado}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Selecciones el numero a Dividir");
                        if (!int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("Por favor, introduce un número válido.");
                            continue;
                        }
                        else
                        {
                            nuevaCalc.Dividir(numero);
                            Console.WriteLine();
                            Console.WriteLine($"Resultado: {nuevaCalc.Resultado}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }
        Console.WriteLine($"Resultado Final {nuevaCalc.Resultado}");
    }
}