using System;

delegate void Show();

class Program
{
    static void Print() => Console.WriteLine("Hello");

    static void Main()
    {
        Show s = Print;
        s();
    }
}