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
        int valor = leitor.nextInt();
        int cem = valor / 100;
        int cqnt = (valor % 100) / 50;
        int vinte = ((valor % 100) % 50 ) / 20;
        int dez = ((valor % 100) % 50 % 20) / 10;
        int cinco = ((valor % 100) % 50 % 20 % 10) / 5 ;
        int dois = ((valor % 100) % 50 % 20 % 10 % 5 ) / 2 ;
        int um = ((valor % 100) % 50 % 20 % 10 % 5  % 2) / 1 ;
        
        System.out.printf("%d%n", valor);
        System.out.printf("%d nota(s) de R$ 100,00\n", cem);
        System.out.printf("%d nota(s) de R$ 50,00\n", cqnt);
        System.out.printf("%d nota(s) de R$ 20,00\n", vinte);
        System.out.printf("%d nota(s) de R$ 10,00\n", dez);
        System.out.printf("%d nota(s) de R$ 5,00\n", cinco);
        System.out.printf("%d nota(s) de R$ 2,00\n", dois);
        System.out.printf("%d nota(s) de R$ 1,00\n", um);
    }
 
}