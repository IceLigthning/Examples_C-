/*
Задача 29: Напишите программу, которая 
задаёт массив из 8 элементов и выводит 
их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

Console.Clear();


Console.WriteLine("Enter some numbers into an array!");

// Вводим число.
int GetNumber()
{
    int resultNumber = 0;

    Console.Write("Enter a number: ");

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

// Выводим пустой массив.
void PrintArr(int[] col)
{
    int count = col.Length;

    int position = 0;

    while (position < count)
    {        
        Console.Write($" {col[position]}");
               
        position++;
    }
}


int[] arr = new int[8]; // Объявляем массив чисел

int sizeArray = arr.Length; // Выщитываем длину массива

Console.WriteLine();

// Через цикл записываем числа в массив!
for (int i = 0; i < sizeArray; i++)
{
    arr[i] = GetNumber(); 
    
}

Console.WriteLine();

// Печатаем значения массива


Console.Write("The array of numbers = [");

PrintArr(arr);

Console.Write(" ]");
