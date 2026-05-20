using System;

public class URI{
    static void Main(string[] args){
        double distance = double.Parse(Console.ReadLine());
        double fuel = double.Parse(Console.ReadLine());

        double c = distance / fuel;

        Console.WriteLine($"{c:F3} km/l");
    }
}