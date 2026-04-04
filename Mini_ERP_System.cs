using System;

class ERP
{
    public void Sales() => Console.WriteLine("Sales Module");
    public void HR() => Console.WriteLine("HR Module");
}

class Program
{
    static void Main()
    {
        ERP e = new ERP();
        e.Sales();
        e.HR();
    }
}