using System.Collections;

float resultado = 0;
return2:
Console.WriteLine("Insira o primeiro número: ");
if (float.TryParse(Console.ReadLine(), out float n1))
{
    Console.Write("Insira a operação: ");
    string operacao = Console.ReadLine();
    return1:
    Console.WriteLine("Insira o segundo número: ");
    if (float.TryParse(Console.ReadLine(), out float n2))
    {
        switch (operacao)
        {
            case "+":
                resultado = n1 + n2;
                Console.Write($"O resultado da operação é {resultado}.");
                break;

            case "-":
                resultado = n1 - n2;
                Console.Write($"O resultado da operaçao é {resultado}");
                break;

            case "*":
                resultado = n1 * n2;
                Console.Write($"O resultado da operação é {resultado}");
                break;

            case "/":
                resultado = n1 / n2;
                Console.Write($"O resultado da operação é {resultado}");
                break;
        }
    }
    else
    {
        Console.Write("Número Inválido.");
        goto return1;
    }
}
else
{
    Console.Write("Número Inválido.");
    goto return2;
}

