using System;

class Program
{
    static void Main()
    {
        int n = 10, a = 0, b = 1;

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}