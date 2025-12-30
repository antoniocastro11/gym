import java.io.IOException;
import java.util.Scanner;
/**
 * IMPORTANT: 
 *      O nome da classe deve ser "Main" para que a sua solução execute
 *      Class name must be "Main" for your solution to execute
 *      El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {
 
    public static void main(String[] args) throws IOException {
            Scanner leitor = new Scanner(System.in);
            
            double a = leitor.nextDouble();
            double b = leitor.nextDouble();
            double c = leitor.nextDouble();
            
            double triangle =  (a * c) / 2;
            double circle = 3.14159 * c * c;
            double trapezium = (a + b) * c / 2;
            double square = b * b;
            double rectangle = a * b;
            
            System.out.printf(
                "TRIANGULO: %.3f%n" +
                "CIRCULO: %.3f%n" +
                "TRAPEZIO: %.3f%n" +
                "QUADRADO: %.3f%n" +
                "RETANGULO: %.3f%n",
                triangle,
                circle,
                trapezium,
                square,
                rectangle
            );
        }
} 