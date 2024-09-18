/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
	static void Main() {



        int v2 = 0;
        int total = 0;
        
		Random randNum = new Random();
		int num = randNum.Next(1,100);


		while(num !=v2)
		{
			Console.WriteLine("Adivinhe um número de 1 a 100");

			//Console.WriteLine("numero é: " + num + "\n");
			v2 = int.Parse(Console.ReadLine());

			if(v2<num)
			{
				Console.WriteLine("Número Acima.");
				total++;
			}
			else if(v2>num)
			{
				Console.WriteLine("Número Abaixo.");
				total++;
			}
			else
			{
				Console.WriteLine("Certo.");
				total++;
			}

		}
        
		Console.WriteLine($"O numero é {num}");
		Console.WriteLine($"A quantidade de tentativas foram {total}");

	}
}