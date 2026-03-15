using System;

class BankBasic
{
    static void Main()
    {
        string[] accountNumbers = new string[10];
        string[] names = new string[10];
        double[] balances = new double[10];

        int count = 0;

        while (true)
        {
            Console.WriteLine("\n1.Create Account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Show Accounts");
            Console.WriteLine("5.Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Account Number: ");
                accountNumbers[count] = Console.ReadLine();

                Console.Write("Enter Name: ");
                names[count] = Console.ReadLine();

                Console.Write("Enter Initial Balance: ");
                balances[count] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Account Created");
                count++;
            }

            else if (choice == 2)
            {
                Console.Write("Enter Account Number: ");
                string acc = Console.ReadLine();

                Console.Write("Enter Deposit Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    if (accountNumbers[i] == acc)
                    {
                        balances[i] += amount;
                        Console.WriteLine("Deposit Successful");
                        Console.WriteLine("Current Balance: " + balances[i]);
                    }
                }
            }

            else if (choice == 3)
            {
                Console.Write("Enter Account Number: ");
                string acc = Console.ReadLine();

                Console.Write("Enter Withdraw Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    if (accountNumbers[i] == acc)
                    {
                        if (balances[i] >= amount)
                        {
                            balances[i] -= amount;
                            Console.WriteLine("Withdraw Successful");
                            Console.WriteLine("Current Balance: " + balances[i]);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                    }
                }
            }

            else if (choice == 4)
            {
                for (int i = 0; i < count; i++)
                {
                    object box = balances[i]; // boxing
                    double unbox = (double)box; // unboxing

                    Console.WriteLine("Account Number: " + accountNumbers[i]);
                    Console.WriteLine("Name: " + names[i]);
                    Console.WriteLine("Current Balance: " + unbox);
                    Console.WriteLine("----------------------");
                }
            }

            else if (choice == 5)
            {
                break;
            }
        }
    }
}