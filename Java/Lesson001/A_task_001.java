/*
 * 
 * Вычислить n-ое треугольного число (сумма чисел от 1 до n), 
 * n! (произведение чисел от 1 до n)
 * 
 */

import java.util.Scanner; 

public class A_task_001 {
    static public void main(String[] args) {
        java.util.Scanner iScan = new Scanner(System.in);
        System.out.printf("Ведите целое число n: ");
        int n = iScan.nextInt();
        iScan.close();

        int count1 = 0;
        for(int i = 1; i <= n; i++) {
            count1 = count1 + i;
        }
        System.out.println("Сумма: ");
        System.out.println(count1);

        int count2 = 1;
        for(int i = 1; i <= n; i++) {
            count2 = count2 * i;
        }
        System.out.println("Произведение: ");
        System.out.println(count2);
    }
}