Console.Write("Insira a primeira nota: ");
string nota = Console.ReadLine();
float notas1 = float.Parse(nota);

Console.Write("Insira a segunda nota: ");
string nota2 = Console.ReadLine();
float notas2 = float.Parse(nota2);

Console.Write("Insira a terceira nota: ");
string nota3 = Console.ReadLine();
float notas3 = float.Parse(nota3);

Console.Write("Insira a quarta nota: ");
string nota4 = Console.ReadLine();
float notas4 = float.Parse(nota4);

float media = (notas1+notas2+notas3+notas4)/4;

if(media>=60)
{
    Console.Write("\n---------Aluno Aprovado!---------");
}
else if(media>=40)
{
    Console.Write("\n---------Aluno de Recuperação!---------");
}
else
{
    Console.Write("\n---------Aluno Reprovado!--------");
}
