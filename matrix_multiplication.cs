using System;

class Program
{
    static void Main()
    {
        int[,] mat1 = { {1, 2}, {3, 4} };
        int[,] mat2 = { {5, 6}, {7, 8} };
        int[,] product = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                product[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    product[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }

        Console.WriteLine("Matrix Multiplication Result:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(product[i, j] + " ");
            Console.WriteLine();
        }
    }
}