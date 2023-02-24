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
double[,] GetMatrix()
{
    double[,] matr= new double[3, 4];
    Random value = new Random();

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = value.Next(0, 11);
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
            Console.Write($" {matr[i,j]}  ");
        }

        Console.WriteLine();
    }

}

void GetAverage(double[,] matr)
{
    double sum = 0;
    int sizeI = matr.GetLength(0);
    int sizeJ = matr.GetLength(1);

    
    for(int j = 0; j < sizeJ; j++)
    {
        
        for(int i = 0; i < sizeI; i++)
        {
            sum += matr[i, j];
            
        }
        Console.Write($" {(sum).ToString("0.00")}; ");

        sum *= 0; // Домножаем сумму значений стольбцов в массиве на 0.
                
    }
    
}


// заполняем масссив
double[,] matrix= GetMatrix();
GetPrint(matrix);

Console.WriteLine("");

Console.Write("Среднее арифметическое значение стольбцов = [");
GetAverage(matrix);
Console.Write("]");





