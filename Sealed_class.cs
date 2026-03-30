using System;

sealed class Parent
{
    public void Show()
    {
        Console.WriteLine("Sealed class");
    }
}

// class Child : Parent {}  ❌ Not allowed

class Program
{
    static void Main()
    {
        Parent p = new Parent();
        p.Show();
    }
}