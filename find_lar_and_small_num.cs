using System;

class Program
{
    static void Main()
    {
        int[] arr = { 15, 42, 7, 99, 23 };
        int largest = arr[0], smallest = arr[0];

        foreach (int num in arr)
        {
            if (num > largest) largest = num;
            if (num < smallest) smallest = num;
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}