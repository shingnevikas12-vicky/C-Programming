using System;

class Program
{
    static void Main()
    {
        Func<int, int> f = x => x * 2;
        Action<string> a = s => Console.WriteLine(s);
        Predicate<int> p = x => x > 5;

        a(f(5).ToString());
        Console.WriteLine(p(10));
    }
}