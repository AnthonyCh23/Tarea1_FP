using System;

class Program
{
    static void Main(string[] args)
    {
        //Entrada
        Console.Write("Ingrese el primer valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        //Proceso
        if (valor1 > valor2)
        {
            Console.WriteLine("El mayor valor es: " + valor1);
        }
        else if (valor2 > valor1)
        {
            Console.WriteLine("El mayor valor es: " + valor2);
        }
        else
        {
            Console.WriteLine("Los valores son iguales");
        }
    }
}