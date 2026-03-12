/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
    public void add(int a,int b){
         int sum=a+b;
         Console.WriteLine(sum);
     }
     public void add(float a,float b){
         float res=a+b;
         Console.WriteLine(res);
     }
     public void add(double a,double b){
         double res1=a+b;
       Console.WriteLine(res1);
     }
  static void Main() {
      //example for method overloading
     
   
  HelloWorld hw=new HelloWorld();
  hw.add(5,3);
  hw.add(4.6,9.7);
  hw.add(800.66,9087.67);
  } 
}