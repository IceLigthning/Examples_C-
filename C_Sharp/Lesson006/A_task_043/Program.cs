/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

// Метод ввода чисел
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

// Заполняем массив;
void GetValuesArray(int[] col)
{
    int size = col.Length;

    for(int i = 0; i < size; i++)
    {
        col[i] = i;
    }
}

// Ищем в точку пересечения функций
void FindingPoint(int[] collect, int kValFirst, int bValFirst, int kValSecond, int bValSecond)
{
    int size = collect.Length;

    // Массивы для сравнения функций.
    int[] arrFirst = new int [size];
    int[] arrSecond = new int [size];

    for(int i = 0; i < size; i++)
    {
        arrFirst[i] = kValFirst * collect[i] + bValFirst;
        arrSecond[i] = kValSecond * collect[i] + bValSecond;

        if(arrFirst[i] == arrSecond[i])
        {
            int valX = collect[i];
            int valY = arrFirst[i];

            Console.WriteLine($"Точка пересечения прямых ({valX}, {valY})");
            
        }
    }
         
}

// Задаём диапазон!

Console.WriteLine("Задаём диапазон функций по Х!");
Console.WriteLine("");
Console.Write("Ведите минимальное значение отрезка: ");
int minValOfArr = GetNumber();
Console.Write("Ведите максимальное значение отрезка: ");
int maxValOfArr = GetNumber();

int numLengthArray = maxValOfArr - minValOfArr;
Console.WriteLine("");
// Ввод параметров для первой функции
Console.WriteLine("Введите числа для первой функкции!");
Console.Write("Ведите k1: ");
int k1Value = GetNumber();
Console.WriteLine("");
Console.Write("Ведите b1: ");
int b1Value = GetNumber();
Console.WriteLine("");

// Ввод параметров для первой функции
Console.WriteLine("Введите числа для второй функкции!");
Console.Write("Ведите k2: ");
int k2Value = GetNumber();
Console.WriteLine("");
Console.Write("Ведите b2: ");
int b2Value = GetNumber();
Console.WriteLine("");


int[] arrayForLine = new int [numLengthArray];

GetValuesArray(arrayForLine);

FindingPoint(arrayForLine, k1Value, b1Value, k2Value, b2Value);