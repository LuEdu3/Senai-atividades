/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
        Console.WriteLine("-----Sorteio Mega-Sena-----");
		Random randNum = new Random();
		randNum.Next(1, 60);
		Console.WriteLine($"\n{randNum.Next(1, 61)},{randNum.Next(1, 61)},{randNum.Next(1, 61)},{randNum.Next(1, 61)},{randNum.Next(1, 61)},{randNum.Next(1, 61)}");
		
		
		 /*for (int i = 1; i <= 1; i++)
		 {
		Console.WriteLine($"{randNum.Next(1, 61)},{randNum.Next(1, 61)},{randNum.Next(1, 60)},{randNum.Next(1, 60)},{randNum.Next(1, 60)},{randNum.Next(1, 60)}");
		
		 }
		/*if(int.TryParse(),out int numbers) && numbers <=10)
		{
		Console.WriteLine($"{numbers} aaa");
		}*/	
		
  }
}