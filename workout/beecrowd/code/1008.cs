using System;

public class URI {
    public static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());
        int hoursWorked = int.Parse(Console.ReadLine());
        float perHour = float.Parse(Console.ReadLine());
        float salary = (float)hoursWorked * perHour;
        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");
    }
}