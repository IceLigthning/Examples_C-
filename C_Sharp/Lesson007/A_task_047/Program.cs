/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5  7   - 2    -0,2
1   -3,3   8    -9,9
8    7,8  -7,1   9

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
Console.WriteLine("");
Console.Write(matrix[1,0]);