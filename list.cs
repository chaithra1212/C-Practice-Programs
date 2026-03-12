/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {

	static void Main() {
		//example for method overloading

		int[] a=new int[] {1,2,4,8,9,12};
		//where clause
		var res=a
		        .Where(n=>n%2!=0);
		foreach(var i in res) {
			Console.WriteLine(i);
		}
		//List Collections
		List<string> list=new List<string>();
		list.Add("Grapes");
		list.Add("Apple");
		list.Add("banana");
		list.Add("Watermeleon");
		list.Add("Amla);
		//Lamda and LINQ with OrderBy
		var fruits= list
		            .OrderBy(a=>a);
		foreach(var j in fruits) {
			Console.WriteLine(j);
		}
		//Contains
		if(list.Contains("Fish")){
		    Console.WriteLine("yes");
		}else{
		    Console.WriteLine("no");
		}
		
	}
}