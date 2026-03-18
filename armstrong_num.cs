using System;

class Program
{
    static void Main()
    {
        int num = 153, original = num, sum = 0;

        while (num != 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }

        if (original == sum)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong Number");
    }
}