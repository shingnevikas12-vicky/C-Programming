using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> hs = new HashSet<int>() { 1, 2, 2, 3 };
        foreach (int i in hs)
            Console.WriteLine(i);
    }
}