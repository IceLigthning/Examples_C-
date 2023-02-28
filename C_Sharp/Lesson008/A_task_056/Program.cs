/*

Задача 56: Задайте прямоугольный двумерный 
массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

Console.Clear();

//Метод для ввода числа с консоли:

int GetNumber(string mess)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(mess);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
        {
            Console.WriteLine("");
            break;
        }
        else
        {
            Console.Write("The number is incorrect! Enter a correct number: ");
        }

    }

    return resultNumber;
}

// Метод заполнения массива:
int[,] GetMatrix(int rank, int colum)
{
    int[,] matr= new int[rank, colum];
    Random value = new Random();

    for(int i = 0; i < rank; i++)
    {
        for(int j = 0; j < colum; j++)
        {
            matr[i,j] = value.Next(0, 100);
        }

    }

    return matr;

}

// Метод печати массива:
void GetPrint(int[,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }

        Console.WriteLine();
    }

}

void GetMaxSumForString(int[,] matr)
{
    int stolbDlin = matr.GetLength(0);
    int strokDlin = matr.GetLength(1);

    int[] arr = new int[stolbDlin];

    int sum = 0;
    int minSum = 0;
    int num = 0;
    

    for(int i = 0; i < stolbDlin; i++)
    {

        for(int j = 0; j < strokDlin-1; j++)
        {

            sum = sum + matr[i,j];

        }
        
        arr[i] = sum;

        Console.WriteLine($"Сумма строки № {i+1} = {arr[i]}");
        sum *=0;
    
    }

    //Находим строку с минимальной суммой элементов!
    for(int i = 0; i < stolbDlin-1; i++)
    {
        if(arr[i] < arr[i+1])
        {
            minSum = arr[i];
        }
        else
        {
            minSum = arr[i+1];
        }
        
    }
    
    // Вывод номер строки с мин суммой элементов!
    for(int i = 0; i < stolbDlin; i++)
    {
        if(minSum == arr[i])
        {
            num = i+1;

        }
    }
    Console.WriteLine("");
    Console.WriteLine($"Строка с номером {num} - строка с минимальной суммой, сумма которой равна {minSum}!");

     

}




// Задаём размер массива:
int ranks = GetNumber("Введите число строк в массиве: ");
int columns = GetNumber("Введите число столбцов в массиве: ");
int[,] matrix = GetMatrix(ranks, columns);

GetPrint(matrix);
Console.WriteLine("");
GetMaxSumForString(matrix);