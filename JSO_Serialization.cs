using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        var obj = new { Name = "Vikas" };
        string json = JsonSerializer.Serialize(obj);

        Console.WriteLine(json);
    }
}