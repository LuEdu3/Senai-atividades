bool verificando = false;

while(verificando == false)
{

Console.Write("Insira a idade: ");

if(int.TryParse(Console.ReadLine(),out int idade))
{
    if(idade<0)
    {
        Console.Write("Erro.");
    }
    else
    verificando = true;
    {
        if(idade<=12)
        {
            Console.Write("Criança");
        }
        else if(idade>=13 && idade<=17)
        {
            Console.Write("Adolescente");
        }
        else if(idade>=18 && idade<=64)
        {
            Console.Write("Adulto");
        }
        else
        {
            Console.Write("Idoso");
        }
    }
}
}