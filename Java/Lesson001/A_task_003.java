/*
 * 
 * Реализовать простой калькулятор
 * 
 */

import java.util.Scanner; 

public class A_task_003 {

    static public void main(String[] args) {
        java.util.Scanner iScan = new Scanner(System.in);

        System.out.printf("Ведите первое число: ");
        int first = iScan.nextInt();
        System.out.printf("Если хотите выполнить сложение введите 1:\n ");
        System.out.printf("Если хотите выполнить вычетание введите 2:\n ");
        System.out.printf("Если хотите выполнить деление введите 3:\n ");
        System.out.printf("Если хотите выполнить умножение введите 4\n ");
        int sign = iScan.nextInt();
        System.out.printf("Ведите второе число: ");
        int second = iScan.nextInt();

        iScan.close();

                        
        if (sign == 1 ){
            System.out.println(first + second);
        }
        else if(sign == 2 ){
            System.out.println(first - second);
        }
        else if(sign == 3 ){
            if (second == 0) {
                System.out.println("На 0 не делим!");
            }
            else {
                System.out.println(first / second);
            }
        }
        else if(sign == 4){
            System.out.println(first * second);
        }
        else
        {
            System.out.println("Вы не ввели арифметический символ или ввели его не привильно!");
        }
        
    }
}
