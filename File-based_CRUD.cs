using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("data.txt", "Hello");
        Console.WriteLine(File.ReadAllText("data.txt"));
    }
}