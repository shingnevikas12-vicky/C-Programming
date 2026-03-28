using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5 }; // Missing 3
        int n = 5;

        int expected = n * (n + 1) / 2;
        int actual = 0;

        foreach (int i in arr)
        {
            actual += i;
        }

        Console.WriteLine("Missing Number = " + (expected - actual));
    }
}