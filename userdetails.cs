using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string phone = Console.ReadLine();

        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phone);

        Console.ReadLine(); 
    }
}