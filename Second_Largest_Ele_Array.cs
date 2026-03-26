using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 5, 8, 25 };

        int largest = int.MinValue;
        int second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                second = num;
            }
        }

        Console.WriteLine("Second Largest = " + second);
    }
}