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

        System.out.printf("Введите арифметический символ: ");
        String sign = iScan.nextLine();

        System.out.printf("Ведите второе число: ");
        int second = iScan.nextInt();
        iScan.close();

        String mark1 = "+";
        String mark2 = "-";
        String mark3 = "/";
        String mark4 = "*";


        if (sign == mark1 ){
            System.out.println(first + second);
        }
        else if(sign == mark2){
            System.out.println(first - second);
        }
        else if(sign == mark3){
            System.out.println(first / second);
        }
        else if(sign == mark4){
            System.out.println(first * second);
        }
        else
        {
            System.out.println("Вы не ввели арифметический символ или ввели его не привильно!");
        }

    }
}
