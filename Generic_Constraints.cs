using System;

class Demo<T> where T : class
{
    public void Show(T val)
    {
        Console.WriteLine(val);
    }
}