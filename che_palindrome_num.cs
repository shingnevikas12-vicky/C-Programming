using System;

class Program
{
    static void Main()
    {
        int num = 121, original = num, reverse = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }

        if (original == reverse)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}