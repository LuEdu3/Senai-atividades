int notas = 0;
int notasrep = 0;
Console.Write("Quantas Notas deseja inserir: ");
notasrep = int.Parse(Console.ReadLine());

for(int i = 0; i<notasrep; i++)
{
    
    Console.Write("Insira a nota: ");
    notas = int.Parse(Console.ReadLine());
}

int media = notas/notasrep;
Console.Write($"A média é {media}");