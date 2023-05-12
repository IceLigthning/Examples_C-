/*
 * 
 * Реализовать простой калькулятор
 * 
 */

import java.util.Scanner; 

public class A_task_003 {

    static public void main(String[] args) {
        java.util.Scanner iScan = new Scanner(System.in);

        System.out.printf("Ведите первое число:\n ");
        int first = iScan.nextInt();
        //System.out.printf("Если хотите выполнить сложение введите 1:\n ");
        //System.out.printf("Если хотите выполнить вычетание введите 2:\n ");
        //System.out.printf("Если хотите выполнить деление введите 3:\n ");
        //System.out.printf("Если хотите выполнить умножение введите 4:\n ");
        System.out.printf("Введите арифметическую операцию:\n ");
        String sign = iScan.nextLine();
        System.out.printf("Ведите второе число:\n ");
        int second = iScan.nextInt();

        iScan.close();

                        
        if (sign == "+"){
            System.out.println(first + second);
        }
        else if(sign == "-"){
            System.out.println(first - second);
        }
        else if(sign == "/"){
            if (second == 0) {
                System.out.println("На 0 не делим!");
            }
            else {
                System.out.println(first / second);
            }
        }
        else if(sign == "*"){
            System.out.println(first * second);
        }
        else
        {
            System.out.println("Вы не ввели арифметический символ или ввели его не привильно!");
        }
        
    }
}
