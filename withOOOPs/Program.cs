using System;

class Program
{
    static void Main()
    {
        BankAccount acc = new SavingsAccount();

        Console.Write("Enter Account Number: ");
        acc.AccountNumber = Console.ReadLine();

        Console.Write("Enter Name: ");
        acc.Name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("\n1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Show Balance");
            Console.WriteLine("4.Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount: ");
                    double d = Convert.ToDouble(Console.ReadLine());
                    acc.Deposit(d);
                    break;

                case 2:
                    Console.Write("Enter amount: ");
                    double w = Convert.ToDouble(Console.ReadLine());
                    acc.Withdraw(w);
                    break;

                case 3:
                    acc.ShowBalance();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}