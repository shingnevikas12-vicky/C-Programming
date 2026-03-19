using System;

class Program
{
    static void Main()
    {
        // Implicit casting
        int num = 10;
        double d = num;

        // Explicit casting
        double x = 9.8;
        int y = (int)x;

        Console.WriteLine("Implicit: " + d);
        Console.WriteLine("Explicit: " + y);
    }
}