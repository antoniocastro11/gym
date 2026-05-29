using System;

public class URI
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int[] numeros = Array.ConvertAll(entrada, int.Parse);
        int distancia = numeros[0];
        int tamanho = numeros[1];
        int resultado = distancia % tamanho;
        Console.WriteLine(resultado);
    }
}

// jeito burro fiquei pensando mo cota:

using System;

public class URI
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int[] numeros = Array.ConvertAll(entrada, int.Parse);
        int distancia = numeros[0];
        int tamanho = numeros[1];
        int voltas = distancia / tamanho;
        int resultado = distancia - voltas * tamanho;
        Console.WriteLine(resultado);
    }
}