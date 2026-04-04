using System;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDb : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder opt)
        => opt.UseInMemoryDatabase("TestDB");
}

class Program
{
    static void Main()
    {
        var db = new AppDb();
        db.Students.Add(new Student { Name = "Vikas" });
        db.SaveChanges();

        foreach (var s in db.Students)
            Console.WriteLine(s.Name);
    }
}