using System;
using System.Threading;

class Program
{
    static void Run()
    {
        Console.WriteLine("Thread running");
    }

    static void Main()
    {
        Thread t = new Thread(Run);
        t.Start();
    }
}