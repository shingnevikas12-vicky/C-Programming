using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string str = Console.ReadLine();

        string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Word count: " + words.Length);
    }
}