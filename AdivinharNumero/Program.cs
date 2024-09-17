using System.Globalization;
using System.Numerics;

int varvalor = 0;
int vartotal = 0;

Random randNum = new Random();
int varnum = randNum.Next(100);

while(varnum !=varvalor)
{
    Console.Write("Advinhe um número de 1 a 100 :");
    
    varvalor = int.Parse(Console.ReadLine());
    
    if(varvalor<varnum)
    {
        Console.WriteLine("Número Acima.");
        vartotal++;
    }
    else if(varvalor>varnum)
    {
        Console.WriteLine("Número Abaixo.");
        vartotal++;
    }
    else
    {
        Console.WriteLine("Certo.");
    }
}
    Console.WriteLine($"A quantidade de tentativas foram {vartotal}.");
    Console.WriteLine($"O número era {varnum}");