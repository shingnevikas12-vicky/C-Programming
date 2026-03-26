using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        PrintArray(arr);
    }
}