using System;

public class URI
{
    public static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());
        int horas = total / 3600;
        int minutos = (total % 3600 )/ 60;
        int segundos = (total % 3600) % 60;
        
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}