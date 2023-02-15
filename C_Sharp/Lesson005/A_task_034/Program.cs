/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных 
чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();

// Заполняем массив 4 случайными числами!
void GenerateArray(int[] collection)
{
    int length = collection.Length;

    int i = 0;

    Random number = new Random();
    while (i < length)
    {
        collection[i] = number.Next(100, 1000);
        i++;
    }

}

// Выводим массив на экран!
void PrintArray(int[] assamblage)
{
    int length = assamblage.Length;

    int i = 0;

    Random number = new Random();

    while (i < length)
    {
        Console.Write($" {assamblage[i]}");

        i++;
    }

}

// Подсчитываем число чётных чисел в массиве!

void SelectEventNumbers(int[] col)
{
    int length = col.Length;
    
    int count = 0;
    for(int i = 0; i < length; i++)
    {
        if(col[i] % 2 == 0)
        {
            count++;   
        }
    }

    Console.Write(count);

}

int[] array = new int[4];

GenerateArray(array);
Console.Write($"The array = [");
PrintArray(array);
Console.Write($" ]!");

Console.WriteLine();

Console.Write($"An amount of event numbers in the array with 4 numbers = ");
SelectEventNumbers(array);
Console.Write($"!");


