/*
Задача 29: Напишите программу, которая 
задаёт массив из 8 элементов и выводит 
их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

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


int arg = GetNumber();

int[] arr = new int[8];

int sizeArray = arr.Length;

for (int i = 0; i < sizeArray; i++)
{
    arr[i] = arg;
    
}

PrintArr(arr);