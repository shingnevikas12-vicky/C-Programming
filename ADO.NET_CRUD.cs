using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        SqlConnection con = new SqlConnection("your_connection_string");
        con.Open();

        SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES(1,'Vikas')", con);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Inserted");
        con.Close();
    }
}