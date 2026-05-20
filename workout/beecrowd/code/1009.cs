using System;

public class URI {
    static void Main(string[] args){
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sells = double.Parse(Console.ReadLine());

        double total = salary + 0.15 * sells;

        Console.WriteLine($"TOTAL = R$ {total:F2}");
    }
}