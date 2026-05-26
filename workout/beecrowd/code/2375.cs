
using System;

public class URI
{
    public static void Main(string[] args)
    {
        int diametro = int.Parse(Console.ReadLine());
        string caixa = Console.ReadLine();
        string[] dimensoes = caixa.Split(' ');
        int h = int.Parse(dimensoes[0]);
        int l = int.Parse(dimensoes[1]);
        int p = int.Parse(dimensoes[2]);

        if (diametro <= h && diametro <= l && diametro <= p)
        {
            Console.WriteLine("S");
        }
        else
            Console.WriteLine("N");
    }
}