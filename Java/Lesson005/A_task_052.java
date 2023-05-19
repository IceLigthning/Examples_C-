/*
 * 
 * Пусть дан список сотрудников:

Иван Иванов+
Светлана Петрова+
Кристина Белова+
Анна Мусина+
Анна Крутова+
Иван Юрин+
Петр Лыков+
Павел Чернов+
Петр Чернышов+
Мария Федорова+
Марина Светлова+
Мария Савина+
Мария Рыкова+
Марина Лугова+
Анна Владимирова+
Иван Мечников+
Петр Петин+
Иван Ежов

Написать программу, которая найдёт и выведет повторяющиеся имена с количеством повторений. Отсортировать по убыванию популярности.
 * 
 */

package Education_GeekBrains.Java.Lesson005;

import java.util.HashMap;
import java.util.Map;

public class A_task_052 {
    
    // Функция добавляющая в конец массива новые элементы 
    private static String[] append(String[] arr, String element) {
    
        String[] array = new String[arr.length + 1];
        System.arraycopy(arr, 0, array, 0, arr.length);
        array[arr.length] = element;
        return array;
    }
    public static void main(String[] args) {
        String[] nameWorkers = {
                "Иван Иванов", 
                "Светлана Петрова", 
                "Кристина Белова", 
                "Анна Мусина", 
                "Анна Крутова",
                "Иван Юрин", 
                "Петр Лыков", 
                "Павел Чернов", 
                "Петр Чернышов", 
                "Мария Федорова", 
                "Марина Светлова", 
                "Мария Савина", 
                "Мария Савина", 
                "Мария Рыкова", 
                "Марина Лугова", 
                "Анна Владимирова", 
                "Иван Мечников", 
                "Петр Петин", 
                "Иван Ежов"
            };

        String[] lastNameWorkers = {};
        int size = nameWorkers.length;
 
        //Создаём новый массив выбрав первое словл
        for (int k = 0; k < size; k++) {
            String h = nameWorkers[k];
            String[] name = h.split (" ");
            String firstWord = name[0];
            lastNameWorkers = append(lastNameWorkers, firstWord);
            
        }

        HashMap<String, Integer> workers = new HashMap<>();

        for (String i : lastNameWorkers) {
            
            int newValue = workers.getOrDefault(i, 0) + 1;
            workers.put(i, newValue);
        }
        System.out.println(workers);

        workers.entrySet().stream()
                .sorted(Map.Entry.<String, Integer>comparingByValue().reversed())
                .forEach(System.out::println);
    }

}
