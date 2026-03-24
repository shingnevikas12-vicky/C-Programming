using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        string result = str.Replace(" ", "");

        Console.WriteLine("Without spaces: " + result);
    }
}