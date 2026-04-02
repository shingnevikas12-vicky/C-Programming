using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < 100000; i++) { }

        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}