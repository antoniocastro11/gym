using System

public class URI{
    static void Main(string[] args){
        string entrada = Console.ReadLine();
        string[] numeros = entrada.Split(' ');

        int a = int.Parse(numeros[0]);
        int b = int.Parse(numeros[1]);
        int c = int.Parse(numeros[2]);

        int maior = a;

        if (maior < b){
            maior = b;
        }

        else if(maior < c){
            maior = c;
        }

        Console.WriteLine($"{maior} eh o maior");
    }
}