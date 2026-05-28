using System;

public class URI
{
    public static void Main(string[] args)
    {
        int[] gramasPorPorcao = { 300, 1500, 600, 1000, 150 };
        int total = 225;
        for (int i = 0; i < gramasPorPorcao.Length; i++)
        {
            int quantidade = int.Parse(Console.ReadLine());
            total += quantidade * gramasPorPorcao[i];
        }

        Console.WriteLine(total);
    }
}