using System;

// Single Responsibility Principle
class Report
{
    public void Generate()
    {
        Console.WriteLine("Report Generated");
    }
}

// Open/Closed Principle
interface IDiscount
{
    double GetDiscount(double price);
}

class FestivalDiscount : IDiscount
{
    public double GetDiscount(double price)
    {
        return price * 0.9;
    }
}

class Program
{
    static void Main()
    {
        Report r = new Report();
        r.Generate();

        IDiscount d = new FestivalDiscount();
        Console.WriteLine(d.GetDiscount(1000));
    }
}