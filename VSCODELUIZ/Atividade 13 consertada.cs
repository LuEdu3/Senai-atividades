using System;
class HelloWorld {
	static void Main() {

		Console.WriteLine("-----Sorteio Mega-Sena-----");
		Random randNum = new Random();

		Console.Write("Quantidade de jogos: ");
		int jogos = int.Parse(Console.ReadLine());

		Console.Write("Digite a quantidade de dezenas Min:6 Max: 15: ");
		int quantdez = int.Parse(Console.ReadLine());



		while(quantdez<6 || quantdez>15)
		{
			Console.Write("Informe outra dezena. Min:6 Max: 15: ");
			quantdez = int.Parse(Console.ReadLine());
		}


		for(int j = 1; j <=jogos; j++)
		{
			int num = randNum.Next(1,60);
			if(num<10)
			{

				Console.Write($"0{num} ");
			}
			else
			{

				Console.Write($"{num} ");
			}


			for(int i= 1; i<=quantdez; i++)
			{
				num = randNum.Next(1,60);
				if(num<10)
				{
					Console.Write($"0{num} ");
				}
				else
				{

					Console.Write($"{num} ");
				}

			}
			Console.Write("\n");
		}



	}
}
