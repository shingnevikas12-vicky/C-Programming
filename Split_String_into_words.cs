using System;

class Program
{
    static void Main()
    {
        string str = "C Sharp Programming Language";
        string[] words = str.Split(' ');

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}