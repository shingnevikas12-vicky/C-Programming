using System;

class Program
{
    const double PI = 3.14;
    readonly int value;

    public Program()
    {
        value = 10;
    }

    static void Main()
    {
        Program obj = new Program();
        Console.WriteLine("Constant PI: " + PI);
        Console.WriteLine("Readonly value: " + obj.value);
    }
}