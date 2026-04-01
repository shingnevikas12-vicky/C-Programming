using System;

class Demo
{
    public event Action OnCall;

    public void Trigger()
    {
        OnCall?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.OnCall += () => Console.WriteLine("Event triggered");
        d.Trigger();
    }
}