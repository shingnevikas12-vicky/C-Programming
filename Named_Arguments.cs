using System;

class Program
{
    static void Display(string name, int age)
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    static void Main()
    {
        Display(age: 20, name: "Vikas");
    }
}