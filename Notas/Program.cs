
Console.Write("Escreva a nota: ");
string notav = Console.ReadLine();

float notas2 = float.Parse(notav);

if(notas2>=10)
{
    Console.Write("Aprovado.");
}
else if(notas2>=5)
{
    Console.Write("Recuperação");
}
else
{
    Console.Write("Reprovado");
}
