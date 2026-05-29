using System;

public class URI
{
    public static void Main(string[] args)
    {
        int entradas = int.Parse(Console.ReadLine());
        int total = 0;
        for (int i = 0; i < entradas; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int[] distancia = Array.ConvertAll(valores, int.Parse);
            total += distancia[0] * distancia[1];
        }
        Console.WriteLine(total);
    }
}