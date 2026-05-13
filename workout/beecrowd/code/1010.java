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
        
        int cod1 = leitor.nextInt();
        int qtd1 = leitor.nextInt();
        double uprice1 = leitor.nextDouble();
        
        int cod2 = leitor.nextInt();
        int qtd2 = leitor.nextInt();
        double uprice2 = leitor.nextDouble();
        
        double total = qtd1 * uprice1 + qtd2 * uprice2;
        
        System.out.printf("VALOR A PAGAR: R$ %.2f%n", total);
        
    }
 
}