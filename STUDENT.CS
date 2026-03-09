using System;
namespace First
{
class Program
{
    static void Main(string[] args) {
        //login functionality and reading student info and calculate result
         Console.WriteLine("Student Details:");
        Console.WriteLine("Enter ur name");
        string name=Console.ReadLine();
        Console.WriteLine("rollno");
        string rollno=Console.ReadLine();
        Console.WriteLine("email");
         string email=Console.ReadLine();
         Console.WriteLine("Enter your marks");
         int[] marks=new int[5];
         for(int i=0;i<5;i++){
             marks[i]=Convert.ToInt32(Console.ReadLine());
         }
        
     Console.WriteLine("Verify the login by entering ur rollno\n");
     string verify=Console.ReadLine();
     if(string.Equals(rollno,verify)){
         myDetails(name,rollno,email,marks);
     }else{
         Console.Write("Reenter the valid rollno");
     }

    }
   static void myDetails(string name,string rollno,string email,int[] marks){
         int res=0;
         for(int i=0;i<5;i++){
             res+=marks[i];
         }
         res=res/5;
         Console.WriteLine("Student Details:");
         Console.WriteLine("Student Name: "+name +"\nRollno: "+rollno+"\nemail "+email+"\nGrade(Result): "+res);
    }
}
}
