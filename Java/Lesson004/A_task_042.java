/*
 * 
 * Реализуйте очередь с помощью LinkedList со следующими методами:
enqueue() - помещает элемент в конец очереди, dequeue() - возвращает 
первый элемент из очереди и удаляет его, first() - возвращает первый 
элемент из очереди, не удаляя.
 * 
 */

package Education_GeekBrains.Java.Lesson004;

import java.util.Random;
import java.util.LinkedList;


public class A_task_042 {
    public static void main(String[] args) {

        LinkedList<Integer> originalList = new LinkedList<>();

        Random randVal = new Random();

        for (int i = 0; i < 12; i++) {
            originalList.add(i, randVal.nextInt(100));
        }

        System.out.printf("Исходный список: %s \n", originalList);
        System.out.printf("Список с добавлением элемента в конец %s \n", enqueue(originalList, 15));

        System.out.printf("Первый элемент списка %s \n", dequeue(originalList));
        System.out.printf("Исходный список после удаления первого элемента : %s \n", originalList);

        System.out.printf("Первый элемент списка %s \n", first(originalList));
        System.out.printf("Исходный список без удаления первого элемента: %s \n", originalList);
    }

    // enqueue(): добавление элемент в конец списка
    public static LinkedList<Integer> enqueue(LinkedList<Integer> list, int value) {
        list.addLast(value);

        return list;
    }

    // dequeue(): возвращает первый элемент из очереди и удаляет его,
    public static int dequeue(LinkedList<Integer> list) {
        int value1 = list.getFirst();

        // System.out.printf("Первый элемент в списке: %s \n", list.getFirst());
        list.removeFirst();

        return value1;
    }

    // first(): возвращает первый элемент из очереди, не удаляя
    public static int first(LinkedList<Integer> list) {

        return list.getFirst();
    }

}