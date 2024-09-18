using System.Runtime.Serialization;

Console.WriteLine("Índice de Massa Corporal");
return2:
Console.Write("Informar o peso(kg):");
if(double.TryParse(Console.ReadLine(),out double peso))
{
    return1:
    Console.Write("Informe a altura(m): ");
    
    if(double.TryParse(Console.ReadLine(),out double altura))
    {

    Console.WriteLine("Tem alguma doença?");
    Console.WriteLine("(1) Diabetes.");
    Console.WriteLine("(2) Problemas nas articulações (Ex.: artrite).");
    Console.WriteLine("(3) Problemas cardíacos.");
    Console.WriteLine("(4) Obesidade.");
    Console.WriteLine("(5) Dores nas costas.");
    Console.WriteLine("(6) Ansiedade ou estresse.");
    Console.WriteLine("Insira uma opção: ");


        string doenca = Console.ReadLine();
        
        

        Console.Clear();

        double resultado = peso /( altura * altura);
   switch(doenca)
    {
        case "1":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Caminhadas rápidas");
        Console.WriteLine("Natação");
        Console.WriteLine("Treinamento de resistência (com pesos leves a moderados)");
        Console.WriteLine("Exercícios aeróbicos de baixa intensidade");
        Console.WriteLine("Yoga (ajuda no controle do estresse e glicemia)");
        break;

        case "2":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Hidroginástica");
        Console.WriteLine("Caminhadas leves");
        Console.WriteLine("Ciclismo (com baixa resistência)");
        Console.WriteLine("Alongamentos e yoga");
        Console.WriteLine("Pilates (fortalecimento sem sobrecarga articular)");
        break;

        case "3":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Caminhadas moderadas");
        Console.WriteLine("Bicicleta leve");
        Console.WriteLine("Natação");
        Console.WriteLine("Exercícios de alongamento");
        Console.WriteLine("Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio)");
        break;

        case "4":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Caminhadas e caminhadas rápidas");
        Console.WriteLine("Natação");
        Console.WriteLine("Exercícios em bicicleta ergométrica");
        Console.WriteLine("Exercícios aeróbicos de baixo impacto");
        Console.WriteLine("Hidroginástica");
        break;

        case "5":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Caminhada em ritmo leve");
        Console.WriteLine("Natação ou hidroginástica");
        Console.WriteLine("Yoga com foco em alongamento e fortalecimento do núcleo");
        Console.WriteLine("Pilates (fortalecimento do núcleo)");
        Console.WriteLine("Exercícios de alongamento e mobilidade");
        break;

        case "6":
        Console.WriteLine($"Peso inserido {peso} quilos.");
        Console.WriteLine($"Altura inserida {altura} metros.");
        Console.WriteLine($"Índice corporal é de {resultado:F2}\n");

        Console.WriteLine("Atividades Recomendadas\n");
        Console.WriteLine("Yoga");
        Console.WriteLine("Tai Chi");
        Console.WriteLine("Meditação guiada (combinada com alongamentos)");
        Console.WriteLine("Caminhadas ao ar livre");
        Console.WriteLine("Dança (para liberar endorfina)");
        break;
    }
    
        
}
else
{
            Console.WriteLine("Altura nao informada ou digitada errado.");
            goto return1;
            
    }
}
else
{
            Console.WriteLine("Peso nao informado ou digitado errado.");
            goto return2;
    }
