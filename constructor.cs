using System;

class Student
{
    public string name;

    public Student(string n)
    {
        name = n;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Vikas");
        s.Show();
    }
}