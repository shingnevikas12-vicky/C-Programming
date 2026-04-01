using System;

class Program
{
    static void Main()
    {
        Func<int, int> f = delegate (int x) { return x * x; };
        Console.WriteLine(f(4));
    }
}