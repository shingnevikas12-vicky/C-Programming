using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };

        Span<int> span = arr;
        span[0] = 100;

        ReadOnlySpan<int> readOnlySpan = arr;

        Console.WriteLine("Span First Value: " + span[0]);
        Console.WriteLine("ReadOnlySpan First Value: " + readOnlySpan[0]);
    }
}