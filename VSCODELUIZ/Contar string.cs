/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
	static void Main() {


		Console.WriteLine("Escreva a palavra: ");

		string palavra = Console.ReadLine();

		Console.WriteLine("Escolha a letra a contar: ");

		char letra = char.Parse(Console.ReadLine());

		int total = 0;

		for(int contabil = 0; contabil < palavra.Length; contabil++)
		{
			if(letra == palavra[contabil])
			{
				total++;

			}
		}
		Console.WriteLine($"A letra {letra} foi contada {total} vezes.");
	}
}