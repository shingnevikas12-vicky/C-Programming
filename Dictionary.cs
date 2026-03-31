using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> d = new Dictionary<int, string>();
        d.Add(1, "A");

        Console.WriteLine(d[1]);
    }
}