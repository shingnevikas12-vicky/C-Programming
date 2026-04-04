using System;

class Bank
{
    double balance = 1000;

    public void Deposit(double amt) => balance += amt;
    public void Withdraw(double amt) => balance -= amt;
    public void Show() => Console.WriteLine(balance);
}

class Program
{
    static void Main()
    {
        Bank b = new Bank();
        b.Deposit(500);
        b.Withdraw(200);
        b.Show();
    }
}