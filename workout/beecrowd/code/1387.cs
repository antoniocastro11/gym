using System;

public class URI
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            if (entrada == "0 0")
            {
                break;
            }
            ;
            string[] filhos = entrada.Split(' ');
            int result = int.Parse(filhos[0]) + int.Parse(filhos[1]);
            Console.WriteLine(result);
        }
        ;
    }
}