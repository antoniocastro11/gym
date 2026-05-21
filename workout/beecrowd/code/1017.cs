using System;

public class URI {
    static void Main(string[] args){
        int time = int.Parse(Console.ReadLine());
        int speed = int.Parse(Console.ReadLine());

        int distance = time * speed;

        double consume = distance / 12.0;

        Console.WriteLine($"{consumo:F3}");
    }
}