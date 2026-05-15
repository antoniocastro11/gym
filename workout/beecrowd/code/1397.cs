using System;

public class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            int rodadas = int.Parse(Console.ReadLine());
            if (rodadas == 0)
                break;
            int pontosA = 0;
            int pontosB = 0;
            for (int i = 1; i <= rodadas; i++)
            {
                string jogada = Console.ReadLine();
                string[] numeros = jogada.Split(' ');
                int numA = int.Parse(numeros[0]);
                int numB = int.Parse(numeros[1]);

                if (numA > numB)
                {
                    pontosA++;
                }
                else if (numB > numA)
                {
                    pontosB++;
                }
            }
            Console.WriteLine($"{pontosA} {pontosB}");

        }
    }
}