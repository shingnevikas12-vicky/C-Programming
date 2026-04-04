using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter role: ");
        string role = Console.ReadLine();

        if (role == "admin")
            Console.WriteLine("Full Access");
        else if (role == "user")
            Console.WriteLine("Limited Access");
        else
            Console.WriteLine("No Access");
    }
}