using System;

class Employee
{
    public string Name;
    public double Salary;

    public void Show()
    {
        Console.WriteLine(Name + " Salary: " + Salary);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee { Name = "Vikas", Salary = 50000 };
        e.Show();
    }
}