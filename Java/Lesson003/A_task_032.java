/*
 * 
 * Пусть дан произвольный список целых чисел. Удалить из него чётные числа.
 * 
 */

package Education_GeekBrains.Java.Lesson003;

import java.util.Random;
import java.util.ArrayList;

public class A_task_032 {
    public static void main(String[] args) {
        ArrayList<Integer> array = new ArrayList<Integer>();
        Random randVal = new Random();

        for (int i = 0; i < 10; i++) {
            int val = randVal.nextInt(10);
            array.add(val);
        }
        System.out.println(array);

        for (int i = 0; i < array.size(); i++) {
            if (array.get(i) % 2 == 0) {
                array.remove(array.get(i));
                i--;
            }
        }

        System.out.println(array);
    }
}