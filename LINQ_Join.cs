using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2 };
        string[] b = { "One", "Two" };

        var result = a.Zip(b, (x, y) => x + " " + y);

        foreach (var i in result)
            Console.WriteLine(i);
    }
}