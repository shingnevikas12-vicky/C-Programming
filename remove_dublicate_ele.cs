using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1, 5 };
        int[] distinctArr = arr.Distinct().ToArray();

        Console.WriteLine("Array without duplicates:");
        foreach (int num in distinctArr)
            Console.Write(num + " ");
    }
}