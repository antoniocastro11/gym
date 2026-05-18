using System;

public class HelloWorld
{
	public static void Main(string[] args)
	{
		string entrada1 = Console.ReadLine();
		string entrada2 = Console.ReadLine();

		string[] valores1 = entrada1.Split(' ');
		int codigo1 = int.Parse(valores1[0]);
		float qntd1 = float.Parse(valores1[1]);
		float preco1 = float.Parse(valores1[2]);

		string[] valores2 = entrada2.Split(' ');
		int codigo2 = int.Parse(valores2[0]);
		float qntd2 = float.Parse(valores2[1]);
		float preco2 = float.Parse(valores2[2]);

		float calc1 = qntd1 * preco1;
		float calc2 = qntd2 * preco2;
		float total = calc1 + calc2;
		Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

	}
}