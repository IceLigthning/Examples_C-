/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split()) 
*/

Console.Clear();

// Ввод данных;
Console.WriteLine("Введите с клавиатуры несколько чисел, любое количество!");
Console.Write("Введите числа: ");
// Замена запятых на пробелы на пустые символы или пробелы; 
string text = Console.ReadLine().Replace(",", "");

// Выделение одельных элементов;
// Записываем их в массив;
var data = text.Split(" ")
               .ToArray();

int GetAmount(string[] collection)
{
    int size = collection.Length;
    int count = 0;
    
    for(int i = 0; i < size; i++)
    {
        int number = Convert.ToInt32(collection[i]);

        // Сравниваем
        if(number > 0)
        {
            count++;
        }
    }
    
    return count;

}

// Вывод
Console.Write("Количество чисел значение которых больше 0: ");
Console.WriteLine(GetAmount(data));