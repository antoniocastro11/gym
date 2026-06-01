using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int[] copos = Array.ConvertAll(entrada, int.Parse);
        Console.WriteLine(Array.IndexOf(copos, 1) + 1);
    }
}