using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();
        s.Push(10);

        Queue<int> q = new Queue<int>();
        q.Enqueue(20);

        Console.WriteLine(s.Pop());
        Console.WriteLine(q.Dequeue());
    }
}