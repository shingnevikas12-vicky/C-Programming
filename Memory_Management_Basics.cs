using System;

class Program
{
    static void Main()
    {
        int a = 10; // stored in stack

        int[] arr = new int[3]; // stored in heap

        Console.WriteLine("Memory demo done");

        // Garbage Collector automatically frees unused memory
        GC.Collect();
    }
}