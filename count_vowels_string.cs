using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine().ToLower();

        int count = 0;

        foreach (char c in str)
        {
            if ("aeiou".Contains(c))
                count++;
        }

        Console.WriteLine("Vowel count: " + count);
    }
}