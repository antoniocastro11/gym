using System;

public class URI {
    public static void Main(string[] args){
        float nota1 = float.Parse(Console.ReadLine());
        float nota2 = float.Parse(Console.ReadLine());
        float calc = ((nota1 * 3.5f) + (nota2 * 7.5f)) / 11f;
        Console.WriteLine($"MEDIA = {calc:F5}");
    }
}