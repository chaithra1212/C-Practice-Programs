//Assignment1
using System;
namespace First
{
class Program
{
    static void Main(string[] args) {
         Console.WriteLine("Employee Details:");//Variables and value assigning
        string name="Chaithra M";
        string empid="2483392";
        string domain=".NET";
        int sal=10000;
        string number="9897456791";
     Console.WriteLine("Employee Details:");
     Console.WriteLine("Emp Name: "+name +"\nEmp id:"+empid+"\nEmp domain: "+domain+"\nMobile Number: "+number+"\nsalary: "+sal);

    }
}
}
/// Assignment-1 Program-2
using System;
namespace First
{
class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Enter the employee name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter the employee Id");
        string empid=Console.ReadLine();
        Console.WriteLine("Enter the domain name");
        string domain=Console.ReadLine();
        Console.WriteLine("Enter the employee phoneNumber");
        string number=Console.ReadLine();//ReadLine()
     Console.Write("Employee Details:");//Write();
     Console.WriteLine("Emp Name: "+name +"\nEmp id:"+empid+"\nEmp domain: "+domain+"\nMobile Number: "+number);//WriteLine();

    }
}
}
