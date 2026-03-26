using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string password = "Test@1234";

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=]).{6,}$";

        if (Regex.IsMatch(password, pattern))
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");
    }
}