/*
 * 
 * Задан целочисленный список ArrayList. 
 * Найти минимальное, максимальное и среднее арифметичское этого списка.
 * 
 */

package Education_GeekBrains.Java.Lesson003;

import java.util.Random;
import java.util.ArrayList;
import java.util.Collections;

public class A_task_033 {
    public static void main(String[] args) {
        ArrayList<Integer> array = new ArrayList<>();
        Random randVal = new Random();

        int amount_elem = 20;
        for (int i = 0; i < amount_elem; i++) {
            int randNum = randVal.nextInt(100);
            array.add(randNum);
        }
        System.out.println(array);

        int min_num = Collections.min(array);
        System.out.printf("Min знач. в списке: %d \n", min_num);
        int max_num = Collections.max(array);
        System.out.printf("Max знач. в списке: %d \n", max_num);
        int sum_list = array.stream().mapToInt(Integer::intValue).sum();
        int average = sum_list / amount_elem;
        System.out.printf("Ср. ариф. знач. чисел в списке: %d \n", average);
    }
}