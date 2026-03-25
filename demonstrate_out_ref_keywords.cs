using System;

class Program
{
    static void Test(ref int a, out int b)
    {
        a = a + 10;
        b = 50;
    }

    static void Main()
    {
        int x = 5;
        int y;

        Test(ref x, out y);

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
    }
}