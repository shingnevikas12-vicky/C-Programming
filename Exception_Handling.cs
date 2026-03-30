using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}