using System;

public class URI{
    static void Main(string[] args){
        string entrada = Console.ReadLine();
        string[] numeros = entrada.Split(' ');

        double a = double.Parse(numeros[0]);
        double b = double.Parse(numeros[1]);
        double c = double.Parse(numeros[2]);

        double triangle =  (a * c) / 2.0;
        double circle = 3.14159 * c * c;
        double trapezium = (a + b) * c / 2.0;
        double square = b * b;
        double rectangle = a * b;

        Console.WriteLine($"TRIANGULO: {triangle:F3}");
        Console.WriteLine($"CIRCULO: {circle:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezium:F3}");
        Console.WriteLine($"QUADRADO: {square:F3}");
        Console.WriteLine($"RETANGULO: {rectangle:F3}");

    }
}