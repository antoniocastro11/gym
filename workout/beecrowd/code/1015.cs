using System;

public class URI {
    static void Main(string[] args){
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();

        string[] point1 = line1.Split(' ');
        string[] point2 = line2.Split(' ');

        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);

        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);

        double distance = Math.Sqrt((x2 -x1) * (x2 -x1) + (y2 - y1) * (y2 - y1));

        Console.WriteLine($"{distance:F4}");
    }
}