using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 10 / 0;
        }
        catch
        {
            Console.WriteLine("Error occurred");
        }
        finally
        {
            Console.WriteLine("Finally block");
        }
    }
}