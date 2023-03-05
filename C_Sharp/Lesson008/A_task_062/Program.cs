/*

Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

Console.Clear();

// Ввод числа:
int GetNumber(string mess)
{
    int resultNumber = 0;

    while(true)
    {
        Console.Write(mess);

        if(int.TryParse(Console.ReadLine(), out resultNumber))
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

// Задаём размер матрицы
int length = GetNumber("Введите размер квадратной матрицы: ");
int[,] matrix = new int[length, length];

// Заполняем матрицу спирально
void MadeSpiralMatrix(int[,] matix) 
{
    int row = 0;
    int col = 0;
    int value = 1;

    while (value <= matix.GetLength(0) * matix.GetLength(1))
    {
        matix[row, col] = value;

        value++;

        if (row <= col + 1 && row + col < matrix.GetLength(1) - 1)
            col++;
            
        else if (row < col && row + col >= matrix.GetLength(0) - 1)
            row++;

        else if (row >= col && row + col > matrix.GetLength(1) - 1)
            col--;

        else
            row--;
    }
}

//Печатаем матрицу
void PrintMatrix(int[,] matr)
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

// Выводим матрицу на консоль
MadeSpiralMatrix(matrix);
PrintMatrix(matrix);