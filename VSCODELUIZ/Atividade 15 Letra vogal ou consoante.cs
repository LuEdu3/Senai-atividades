/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Escreva a letra: ");
    string letra = Console.ReadLine().ToLower();
    
    switch (letra)
    {
        case "a":
            Console.WriteLine("É vogal.");
        break;
        case "e":
            Console.WriteLine("É vogal.");
        break;
        case "i":
            Console.WriteLine("É vogal.");
        break;
        case "o":
            Console.WriteLine("É vogal.");
        break;
        case "u":
            Console.WriteLine("É vogal.");
        break;
        default:
            Console.WriteLine("É consoante.");
        break;
    }
    
  }
}