using System;

class Program
{
    static void Main()
    {
        int[] arr = { 50, 20, 10, 40, 30 };
        Array.Sort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}