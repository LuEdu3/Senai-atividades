double moeda;

Console.Write("Valor a converter em reais: ");
if(int.TryParse(Console.ReadLine(), out int valor))
{
        Console.WriteLine("Para qual moeda você quer converter ?");
        string conversao = Console.ReadLine();
        // Console.WriteLine("Dólar");
        // Console.WriteLine("Euro");
        // Console.WriteLine("Libra");
        switch (conversao)
        {
            case "dolar":
            moeda = valor*0.18;
            Console.Write($"O valor em dólar é $ {moeda}");
            break;
            case "euro":
            moeda = valor*0.16;
            Console.Write($"O valor em dólar é $ {moeda}");
            break;
            case "libra":
            moeda = valor*0.14;
            Console.Write($"O valor em dólar é $ {moeda}");
            break;
            default:
            Console.Write("Valor Inválido.");
            break;
        
    }
    Console.Write("Valor Inválido.");
}
Console.Write("Número não foi digitado.");