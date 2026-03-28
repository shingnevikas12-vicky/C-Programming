using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 3, 4, 5, 6 };

        foreach (int i in a)
        {
            foreach (int j in b)
            {
                if (i == j)
                {
                    Console.WriteLine("Common: " + i);
                }
            }
        }
    }
}