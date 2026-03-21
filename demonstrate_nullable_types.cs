using System;

class Program
{
    static void Main()
    {
        int? nullableInt = null;

        if (nullableInt.HasValue)
            Console.WriteLine("Value: " + nullableInt.Value);
        else
            Console.WriteLine("nullableInt has no value.");

        nullableInt = 25;
        Console.WriteLine("Now nullableInt = " + nullableInt);
    }
}