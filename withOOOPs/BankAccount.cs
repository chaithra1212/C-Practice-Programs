using System;

public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public string Name { get; set; }

    protected double balance;

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);

    public void ShowBalance()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Current Balance: " + balance);
    }
}