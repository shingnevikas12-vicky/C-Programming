using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add 2.View 3.Delete");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Student s = new Student();
                Console.Write("Id: ");
                s.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                s.Name = Console.ReadLine();
                students.Add(s);
            }
            else if (ch == 2)
            {
                foreach (var s in students)
                    Console.WriteLine(s.Id + " " + s.Name);
            }
            else if (ch == 3)
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                students.RemoveAll(x => x.Id == id);
            }
        }
    }
}