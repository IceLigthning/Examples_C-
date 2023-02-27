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

int GetMaxString(int[,] matr)
{
    int sum = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {

        for(int j = 0; j < matr.GetLength(1)-1; j++)
        {

            sum = sum + matr[i,j];


        }
        return sum;
        sum *=0;

        

    }
    
}



// Задаём размер массива:
int ranks = GetNumber("Введите число строк в массиве: ");
int columns = GetNumber("Введите число столбцов в массиве: ");
int[,] matrix = GetMatrix(ranks, columns);

GetPrint(matrix);

GetMaxString(matrix);
Console.WriteLine();
GetPrint(matrix);