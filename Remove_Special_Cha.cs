using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello@123#World!";
        string result = Regex.Replace(input, "[^a-zA-Z0-9]", "");

        Console.WriteLine(result);
    }
}