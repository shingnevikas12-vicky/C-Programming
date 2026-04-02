using System;
using System.Threading;

class Program
{
    static object obj = new object();

    static void Main()
    {
        lock (obj)
        {
            Console.WriteLine("Locked section");
        }
    }
}