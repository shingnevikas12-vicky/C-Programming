using System;

class Demo<T>
{
    public T value;
}

class Program
{
    static void Main()
    {
        Demo<int> d = new Demo<int>();
        d.value = 10;
        Console.WriteLine(d.value);
    }
}