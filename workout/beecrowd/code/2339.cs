using System;

public class URI
{
    public static void Main(string[] args)
    {
        string[] entradaString = Console.ReadLine().Split(' ');
        int[] entrada = Array.ConvertAll(entradaString, int.Parse);
        int alunos = entrada[0];
        int folhas = entrada[1];
        int porAluno = entrada[2];

        if (alunos * porAluno <= folhas)
            Console.WriteLine("S");
        else
            Console.WriteLine("N");
    }
}