/*

Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого 
элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7

*/

Console.Clear();

//Метод для ввода числа с консоли:
int GetNumber(string mess)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(mess);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber >= 0)
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
int[,] GetMatrix()
{
    int[,] matr= new int[3, 3];
    Random value = new Random();

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = value.Next(-12, 13);
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

void GetValue(int[,] mat, int ran, int colum)
{
    // Определяем длину столбцов и строк в матрице
    int sizeRanks = mat.GetLength(0);
    int sizeColums = mat.GetLength(0);

    if(0 <= ran && ran < sizeRanks && 0 <= colum && colum < sizeColums)
    {
        Console.WriteLine($"Значение элемента массива с позицией ({Convert.ToString(ran)}, {Convert.ToString(colum)}) = {Convert.ToString(mat[ran, colum])}.");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет!");
    }

    
}


// заполняем масссив
int[,] matrix= GetMatrix();
GetPrint(matrix);


int ranks = GetNumber("Введите позицию по строке: ");
int columns = GetNumber("Введите позицию по стольбцу: ");

Console.WriteLine("");

GetValue(matrix, ranks, columns);






