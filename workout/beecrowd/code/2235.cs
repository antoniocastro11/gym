using System;

public class URI
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int[] numeros = Array.ConvertAll(entrada, int.Parse);
        int h = numeros[0];
        int p = numeros[1];
        double avg = (double)h / p;
        Console.WriteLine($"{avg:F2}");
    }
}