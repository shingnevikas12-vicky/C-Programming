using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent class");
    }
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Child class");
    }
}

class Program
{
    static void Main()
    {
        Child c = new Child();
        c.Show();
        c.Display();
    }
}