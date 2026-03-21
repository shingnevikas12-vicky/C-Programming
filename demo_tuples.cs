using System;

class Program
{
    static void Main()
    {
        var person = ("Alice", 25, "Engineer");
        Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}, Profession: {person.Item3}");

        // Deconstructing tuple
        var (name, age, profession) = person;
        Console.WriteLine($"{name} is {age} years old and works as {profession}");
    }
}