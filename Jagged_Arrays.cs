using System;

class Program
{
    static void Main()
    {
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int val in jagged[i])
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}