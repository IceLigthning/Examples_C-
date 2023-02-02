/*
Задача 23

Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


*/


int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Have entered a number or an incorrect number. Please, repeat the enter!");
        }
    }
    return  resultNumber;
}
// Вводим число в программу!

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 1;
    while(index < lenght)
    {
        collection[index] = index*index*index;
        index++;
    }

}
// Составляем таблицу кубов!

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 1;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}


int N = GetNumber("Enter a number: ") + 1;
int[ ]array = new int[N];
// Создаём пустой массив.
FillArray(array);
// Заполненый массив.
Console.WriteLine();
//
PrintArray(array);

