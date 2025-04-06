using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Proceso
        double fahrenheit = ((celsius * 9 / 5) + 32);

        // Salida
        Console.WriteLine("Grados Celsius: " + celsius + " equivalen a: " + fahrenheit + " grados Fahrenheit.");
    }
}