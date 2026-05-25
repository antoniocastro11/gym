using System;

public class URI
{
    public static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());
        int cem = total / 100;
        int cinquenta = (total % 100) / 50;
        int vinte = (total % 100 % 50) / 20;
        int dez = (total % 100 % 50 % 20) / 10;
        int cinco = (total % 100 % 50 % 20 % 10) / 5;
        int dois = (total % 100 % 50 % 20 % 5) / 2;
        int um = (total % 100 % 50 % 20 % 5 % 2) / 1;
        Console.WriteLine($"{total}");
        Console.WriteLine($"{cem} nota(s) de R$ 100,00");
        Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
        Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
        Console.WriteLine($"{dez} nota(s) de R$ 10,00");
        Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
        Console.WriteLine($"{dois} nota(s) de R$ 2,00");
        Console.WriteLine($"{um} nota(s) de R$ 1,00");
    }
}