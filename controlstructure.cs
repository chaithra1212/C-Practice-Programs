using System;
namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop,foreach loop,while and do while
            //sum of n numbers
            int n=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i=0;i<=n;i++){
                sum+=i;
            }
            int rev=0;
            Console.WriteLine($"sum of {n} numbers is {sum}");
            //while loop / sum of digits
            
            while(n>0){
                int temp=n%10;
                rev+=temp;
                n=n/10;
            }
            Console.WriteLine($"sum of {n} numbers is {rev}");
            //fibnocci series
            int[] fib=new int[5];
            fib[0]=0;
            fib[1]=1;
            for(int i=2;i<5;i++){
                fib[i]=fib[i-1]+fib[i-2];
            }
            foreach(int num in fib){// foreach
                Console.Write(num+" ");
            }
            }
        }
        
    }