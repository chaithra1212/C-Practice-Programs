using System;
using System.Collections.Generic;
using System.Linq;

class BankAccount
{
    public string AccountNumber { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
}

class BankAdvanced
{
    static List<BankAccount> accounts = new List<BankAccount>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Create Account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Show Accounts");
            Console.WriteLine("4.Exit");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        Deposit();
                        break;

                    case 3:
                        DisplayAccounts();
                        break;

                    case 4:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter Account Number: ");
        string accNo = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Balance: ");
        double bal = Convert.ToDouble(Console.ReadLine());

        accounts.Add(new BankAccount
        {
            AccountNumber = accNo,
            Name = name,
            Balance = bal
        });

        Console.WriteLine("Account Created");
    }

    static void Deposit()
    {
        Console.Write("Enter Account Number: ");
        string accNo = Console.ReadLine();

        var account = accounts.FirstOrDefault(a => a.AccountNumber == accNo);

        if (account != null)
        {
            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Balance += amount;

            Console.WriteLine("Current Balance: " + account.Balance);
        }
        else
        {
            Console.WriteLine("Account Not Found");
        }
    }

    static void DisplayAccounts()
    {
        var result = from acc in accounts
                     select acc;

        foreach (var acc in result)
        {
            Console.WriteLine("Account Number: " + acc.AccountNumber);
            Console.WriteLine("Name: " + acc.Name);
            Console.WriteLine("Current Balance: " + acc.Balance);
            Console.WriteLine("------------------");
        }
    }
}