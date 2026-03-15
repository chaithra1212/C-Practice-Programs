using System;

public class SavingsAccount : BankAccount
{
    public override void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit Successful");
    }

    public override void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Withdraw Successful");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}