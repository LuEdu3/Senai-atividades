
    Console.WriteLine("-----Calculador de imposto sobre o salário-----");
    
    Console.Write("Digite o salário : ");
    float.TryParse(Console.ReadLine(),out float salario);
    
    float imposto1 = salario*0.10f;
    float imposto2 = salario*0.15f;
    float imposto3 = salario*0.20f;
    
    /*switch(salario)
    {
        case "imposto
    }*/
    
    if(salario<=3000)
    {
        Console.Write($"O desconto será de R${imposto1}");
    }
    else if(salario<=6000)
    {
        Console.Write($"O desconto será de R${imposto2}");
    }
    else
    Console.Write($"O desconto será de R${imposto3}");