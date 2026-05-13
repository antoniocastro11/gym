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
        
        int idade = leitor.nextInt();
        
        int anos = idade / 365;
        int meses = (idade % 365) / 30;
        int dias = (idade % 365) % 30;
        
        System.out.printf("%d ano(s)\n", anos);
        System.out.printf("%d mes(es)\n", meses);
        System.out.printf("%d dia(s)\n", dias);
 
    }
 
}