/*

Задача 52. Задайте двумерный массив из целых 
чисел. Найдите среднее арифметическое элементов 
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[,] GetMatrix(int rank, int colum)
{
    double[,] matr= new double[rank, colum];
    Random value = new Random();

    for(int i = 0; i < rank; i++)
    {
        for(int j = 0; j < colum; j++)
        {
            matr[i,j] = value.Next(-10, 11) + value.NextDouble();
        }

    }

    return matr;

}

// Метод печати массива:
void GetPrint(double[,] matr)
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

// Задаём размер массива:
int ranks = GetNumber("Введите число строк в массиве: ");
int columns = GetNumber("Введите число столбцов в массиве: ");
double[,] matrix = GetMatrix(ranks, columns);

GetPrint(matrix);