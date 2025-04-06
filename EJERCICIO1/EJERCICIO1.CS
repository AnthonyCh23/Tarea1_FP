using System;

class Program
{
    static void Main(string[] args)
    {
        //Entrada
        Console.Write("Ingrese el sueldo del primer empleado: ");
        double sueldo1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el sueldo del segundo empleado: ");
        double sueldo2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el sueldo del tercer empleado: ");
        double sueldo3 = double.Parse(Console.ReadLine());
        
        //Proceso
        double nsueldo1 = sueldo1 + (sueldo1 * 0.10);
        double nsueldo2 = sueldo2 + (sueldo2 * 0.12);
        double nsueldo3 = sueldo3 + (sueldo3 * 0.15);
        
        //Salida
        Console.WriteLine("Sueldos actualizados:");
        Console.WriteLine("Empleado 1: " + nsueldo1);
        Console.WriteLine("Empleado 2: " + nsueldo2);
        Console.WriteLine("Empleado 3: " + nsueldo3);
    
    }
}