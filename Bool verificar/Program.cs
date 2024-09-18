bool vefiricando = false;
    while(vefiricando == false)
    {
        Console.WriteLine("Insira um número: ");
        if(int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Digitou certo otario!");
            vefiricando = true;
        }
        else
        {
            Console.WriteLine("Digitou errado otario!!");
        }
    }