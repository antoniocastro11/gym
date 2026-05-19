using System;

public class URI
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double v = (4.0/3.0) * 3.14159 * r * r * r;
        Console.WriteLine($"VOLUME = {v:F3}");
    }
}