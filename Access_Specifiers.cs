using System;

class Demo
{
    public int a = 10;
    private int b = 20;
    protected int c = 30;

    public void Show()
    {
        Console.WriteLine(a + " " + b + " " + c);
    }
}

class Program : Demo
{
    static void Main()
    {
        Program p = new Program();
        Console.WriteLine(p.a);   // public
        Console.WriteLine(p.c);   // protected
    }
}