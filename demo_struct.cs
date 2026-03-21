using System;

struct Point
{
    public int X;
    public int Y;

    public void Display()
    {
        Console.WriteLine($"Point coordinates: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Point p1;
        p1.X = 10;
        p1.Y = 20;
        p1.Display();
    }
}