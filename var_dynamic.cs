using System;

class Program
{
    static void Main()
    {
        var x = 10; // type inferred as int
        Console.WriteLine("var x = " + x);

        dynamic y = "Hello"; // type can change at runtime
        Console.WriteLine("dynamic y = " + y);

        y = 123; // changed type
        Console.WriteLine("dynamic y changed = " + y);
    }
}