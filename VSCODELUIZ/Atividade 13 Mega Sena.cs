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

		Console.Write("Quantidade de jogos: ");
		int jogos = int.Parse(Console.ReadLine());

		Console.Write("Digite a quantidade de dezenas: ");
		string x = Console.ReadLine();
		int quantdez = int.Parse(x);



		if(quantdez<6)
		{
			Console.Write("erro.");
		}

		else
		{
			for(int j = 1; j <=jogos; j++)
			{
			    int num = randNum.Next(1,60);
				if(num<10)
				{
				    
					Console.Write($"0{num} ");
				}
				else
				{
				
					Console.Write($"{num} ");
				}
				

				for(int i= 1; i<=quantdez; i++)
				{
					 num = randNum.Next(1,60);
					if(num<10)
					{
						Console.Write($"0{num} ");
					}
					else
					{
					
						Console.Write($"{num} ");
					}

				}
				Console.Write("\n");
			}
		}


	}
}
