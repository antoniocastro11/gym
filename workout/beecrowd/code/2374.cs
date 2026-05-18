using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int pressaoDesejada = int.Parse(Console.ReadLine());
        int pressaoAtual = int.Parse(Console.ReadLine());
        int diferenca = pressaoDesejada - pressaoAtual;
        Console.WriteLine(diferenca);
    }
}