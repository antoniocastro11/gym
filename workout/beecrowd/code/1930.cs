using System;

class URI
{
    static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');
        int total = 0;

        foreach (var t in entradas)
        {
            total += int.Parse(t);
        }

        Console.WriteLine(total - (entradas.Length - 1));
    }
}