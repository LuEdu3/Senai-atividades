Console.Write("Insira um número para verificar: ");
if(decimal.TryParse(Console.ReadLine(),out decimal numero))
{
    if(numero%2 == 0)
    {
        Console.Write($"O número {numero} é par.");
    }
    else
    {
        Console.Write($"O numero {numero} é ímpar.");
    }
}
else
{
    Console.Write("Erro.");
}