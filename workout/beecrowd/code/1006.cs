using System;

public class URI {
    public static void Main(string[] args){
        float nota1 = float.Parse(Console.ReadLine());
        float nota2 = float.Parse(Console.ReadLine());
        float nota3 = float.Parse(Console.ReadLine());
        float conta = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10f;
        Console.WriteLine($"MEDIA = {conta:F1}");
    }
}