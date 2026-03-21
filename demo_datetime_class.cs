using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + now);

        DateTime birthday = new DateTime(1995, 6, 15);
        Console.WriteLine("Birthday: " + birthday.ToShortDateString());

        TimeSpan age = now - birthday;
        Console.WriteLine("You are approximately " + (age.Days / 365) + " years old.");
    }
}