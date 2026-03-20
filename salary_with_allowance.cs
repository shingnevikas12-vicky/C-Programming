using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter basic salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());

        double hra = 0.1 * basic; // 10% House Rent Allowance
        double da = 0.08 * basic; // 8% Dearness Allowance
        double totalSalary = basic + hra + da;

        Console.WriteLine("Total Salary: " + totalSalary);
    }
}