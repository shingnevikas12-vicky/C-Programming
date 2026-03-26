using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "test@gmail.com";
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
            Console.WriteLine("Valid Email");
        else
            Console.WriteLine("Invalid Email");
    }
}