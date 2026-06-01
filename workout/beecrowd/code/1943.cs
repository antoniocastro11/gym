using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int pos = int.Parse(Console.ReadLine());

        if (pos == 1)
            Console.WriteLine("Top 1");
        else if (pos <= 3)
            Console.WriteLine("Top 3");
        else if (pos <= 5)
            Console.WriteLine("Top 5");
        else if (pos <= 10)
            Console.WriteLine("Top 10");
        else if (pos <= 25)
            Console.WriteLine("Top 25");
        else if (pos <= 50)
            Console.WriteLine("Top 50");
        else
            Console.WriteLine("Top 100");
    }
}