/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
Console.WriteLine("------Conversor de Medidas------");
	
		Console.Write("Digite a distância em metros: ");
		float.TryParse(Console.ReadLine(),out float metro);
		
		float cm = metro/0.01f;
		float km = metro/1000f;
		float mi = metro/1609.34f;

        Console.WriteLine("Escolha a unidade de conversão: ");
        Console.WriteLine("cm -Centímetros.");
        Console.WriteLine("km - Quilômetros.");
        Console.WriteLine("mi - Milhas.");
        string conversao = Console.ReadLine();
        Console.Clear();
        switch(conversao)
        {
        
            case "cm": 
                Console.WriteLine($"\nA conversão de {metro} metros para centímetros é {cm} centímetros.");
            break; 
            
            case "km":
                Console.WriteLine($"\nA conversão de {metro} metros para quilômetros é {km} quilômetros.");
            break;
            
            case "mi":
                Console.WriteLine($"\nA conversão de {metro} metros para milhas é {mi} milhas.");
            break;
        }
        
  }
}