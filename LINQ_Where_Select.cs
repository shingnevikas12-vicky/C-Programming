using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };

        var result = arr.Where(x => x > 2).Select(x => x * 2);

        foreach (var i in result)
            Console.WriteLine(i);
    }
}