Console.Write("Insira o salario: ");

decimal result;
if(decimal.TryParse(Console.ReadLine(),out decimal salario))
{
    if(salario<=3000)
    {
        result = salario*0.10m;
        Console.Write($"O imposto sobre o salário é de R${result}");
    }
    else if(salario<=6000)
    {
        result = salario*0.15m;
        Console.Write($"O imposto sobre o salário é de R${result}");
    }
    else
    {
        result = salario*0.20m;
        Console.Write($"O imposto sobre o salário é de R${result}");
    }
}
else
{
    Console.Write("Erro");
} 
