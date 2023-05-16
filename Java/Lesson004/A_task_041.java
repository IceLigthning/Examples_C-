/*
 * 
 * Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.
 * 
 */


package Education_GeekBrains.Java.Lesson004;


import java.util.Random;
import java.util.LinkedList;


public class A_task_041 {
    public static void main(String[] args) {
        // генератор случ. чисел
        LinkedList<Integer> originalList = new LinkedList<>();
        Random randVal = new Random();
        // формируем массив
        for (int i = 0; i < 12; i++) {

            originalList.add(i, randVal.nextInt(100));
        }

        System.out.printf("Исходный список: %s\n", originalList);
        System.out.printf("Перевернутый список: %s\n", reverseLinkedList(originalList));

    }

    
    public static LinkedList<Integer> reverseLinkedList(LinkedList<Integer> list) {

        LinkedList<Integer> reverseList = new LinkedList<>();

        for (int i = list.size() - 1; i >= 0; i--) {
            reverseList.add(list.get(i));
        }

        return reverseList;
    }
}
