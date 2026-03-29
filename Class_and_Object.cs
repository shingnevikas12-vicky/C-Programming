using System;

class Student
{
    public string name;
    public int age;

    public void Show()
    {
        Console.WriteLine(name + " " + age);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.name = "Vikas";
        s.age = 20;
        s.Show();
    }
}