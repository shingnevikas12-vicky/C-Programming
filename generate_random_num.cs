using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        for(int i = 0; i < 5; i++)
        {
            int num = rnd.Next(1, 101); // random number between 1 and 100
            Console.WriteLine(num);
        }
    }
}