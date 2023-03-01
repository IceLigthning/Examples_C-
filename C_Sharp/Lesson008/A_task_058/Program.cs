/*

Задача 58: Задайте две матрицы. Напишите
программу, которая будет находить произведение 
двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18

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
            matr[i,j] = value.Next(1, 8);
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

void GetChangeMatrix(int[,] matrOne, int[,] matrTwo)
{
    int matrOneA = matrOne.GetLength(0);  // Длина столбца 1 матр.
    int matrOneB = matrOne.GetLength(1);  // Длина строки  1 матр.
    int matrTwoA = matrOne.GetLength(0);    // Длина столбца 2 матр.
    int matrTwoB = matrOne.GetLength(1);    // Длина строки  2 матр.

    if(matrOneB  == matrTwoA)
    {

        int[,] matrix= new int[matrOneB , matrTwoA];

        // Идём по строке
        for(int i = 0; i < matrOneA; i++)
        {

            for(int j = 0; i < matrTwoB; j++)
            {

                for(int k = 0; k < matrOneB; k++)
                {

                    matrix[i,j] = matrix[i,j] + matrOne[i,k] * matrTwo[k,j];

                    Console.Write($"{matrix[i,j]} ");                

                }
                Console.WriteLine();
        }

           
    }
    

    }
    else
    {
        Console.WriteLine("Число столбцов первой матрицы не совпадает с числом строк");
        Console.WriteLine("второй матрицы, значить произведение не возможно.");
        Console.WriteLine("Введите другие длины строк и столбцов для матрицы!");

    }


}

// Задаём размер массивов:
int ranksFirst = GetNumber("Введите число строк в первом массиве: ");
int columnsFirst = GetNumber("Введите число столбцов в первом массиве: ");
int[,] matrixFirst = GetMatrix(ranksFirst, columnsFirst);

int ranksSecond = GetNumber("Введите число строк в первом массиве: ");
int columnsSecond = GetNumber("Введите число столбцов в первом массиве: ");
int[,] matrixSecond = GetMatrix(ranksSecond, columnsSecond);

GetPrint(matrixFirst);
Console.WriteLine();

GetPrint(matrixSecond);
Console.WriteLine();


GetChangeMatrix(matrixFirst, matrixSecond);
Console.WriteLine();
