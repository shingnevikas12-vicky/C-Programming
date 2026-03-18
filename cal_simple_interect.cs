using System;

class Program
{
    static void Main()
    {
        double p, r, t, si;

        Console.Write("Enter Principal: ");
        p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        t = Convert.ToDouble(Console.ReadLine());

        si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}