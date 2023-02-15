/*

Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

Console.Clear();

// Генерируем массив из случайных чисел
void GetArray(int[] collection)
{
    int length = collection.Length;

    Random number = new Random();
    
    for(int i = 0; i < length; i++)
    {
        collection[i] = number.Next(-100, 101);
    }

}

// Ищем сумму нечётных позициц элементов массивва!
void FindSumInArray (int[] col)
{
    int size = col.Length;

    int sum = 0;

    for(int j = 0; j < size; j++)
    {
        if(j%2 != 0)
        {
            sum = sum + col[j];
            
        }
    }
    Console.Write(sum);

}

void PrintArray(int[] assamblage)
{
    int length = assamblage.Length;

    int i = 0;

    Random number = new Random();

    while (i < length)
    {
        Console.Write($"{assamblage[i]} ");

        i++;
    }

}

// Вводим число.
int GetNumber()
{
    int resultNumber = 0;

    Console.Write("Enter a number for made a size of array: ");

    while(true)
    {

        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }

        else
        {
            Console.Write("The number is incorrect! Enter a correct number: ");
        }
        
    }
    return resultNumber;
}



int[] array = new int[GetNumber()];

GetArray(array);

Console.Write("The array [ ");
PrintArray(array);
Console.Write("]");

Console.WriteLine();

Console.Write("The sun of array = ");
FindSumInArray(array);
