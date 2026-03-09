using System;
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Banking Application");
            Console.WriteLine("Enter your name\n");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your Account number\n");
            string acc=Console.ReadLine();
            Console.WriteLine("Enter your Phone number\n");
            string phone=Console.ReadLine();
            int bal=0;
            bool flag=true;
            while(flag){
            Console.WriteLine("1.My Profile\n 2.Account\n 3.Deposit\n 4.Withdraw\n 5.exit");
            int sw=Convert.ToInt32(Console.ReadLine());
            switch(sw){
                case 1:profile(name,acc,phone,bal);
                break;
                case 2:account(bal);
                break;
                case 3:deposit(ref bal);
                break;
                case 4:withdraw(ref bal);
                break;
                case 5:
                flag=false;
                break;
                default:Console.WriteLine("Enter the correct choce");
                break;
            }
            }
        }
           
              static void profile(string name,string acc,string phone,int bal){
                Console.WriteLine("User Name:"+name);
                Console.WriteLine("User account number: "+acc);
                Console.WriteLine("user phone number: "+phone);
                Console.WriteLine("Your current balance is: "+bal);
            }
            static void account(int bal){
                Console.WriteLine("Available balance "+bal);
            }
          static void deposit(ref int bal){
                int amount=Convert.ToInt32(Console.ReadLine());
                bal=bal+amount;
                Console.WriteLine("You deposited "+amount);
                Console.WriteLine("Your availble balace "+bal);
            }
            
            static void  withdraw(ref int bal){
                int amount=Convert.ToInt32(Console.ReadLine());
                if(bal<amount){
                    Console.WriteLine("Insufficient balance");
                }else{
                bal=bal-amount;
                Console.WriteLine("Withdrwn amont"+amount);
                Console.WriteLine("Available amount "+bal);
                }
            }
        }
        
    }