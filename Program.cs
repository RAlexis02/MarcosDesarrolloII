using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido a la aplicación de saludo personalizado!");

        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombreUsuario = Console.ReadLine();

        // Mostrar un saludo personalizado
        string saludo = GenerarSaludo(nombreUsuario);
        Console.WriteLine(saludo);

        // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static string GenerarSaludo(string nombre)
    {
        // Generar un saludo personalizado
        return $"Hola, {nombre}! Gracias por usar la aplicación.";
    }
}
