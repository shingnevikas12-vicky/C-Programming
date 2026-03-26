using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "My number is 9876543210";
        string pattern = @"\d+";

        Match match = Regex.Match(text, pattern);

        Console.WriteLine("Found Number: " + match.Value);
    }
}