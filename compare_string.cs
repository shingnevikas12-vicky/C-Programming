using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (string.Compare(str1, str2) == 0)
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");
    }
}