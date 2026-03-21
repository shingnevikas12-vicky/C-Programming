using System;

class Program
{
    static void Main()
    {
        double num = -9.7;

        Console.WriteLine("Absolute value: " + Math.Abs(num));
        Console.WriteLine("Square root: " + Math.Sqrt(16));
        Console.WriteLine("Power: " + Math.Pow(2, 5));
        Console.WriteLine("Ceiling: " + Math.Ceiling(num));
        Console.WriteLine("Floor: " + Math.Floor(num));
        Console.WriteLine("Round: " + Math.Round(num));
    }
}