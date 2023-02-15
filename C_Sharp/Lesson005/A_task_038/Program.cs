/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76

*/

Console.Clear();

// Задаём массив из случайных чисел
void GetArray(double[] collection, int minVal, int maxVal)
{
    int size = collection.Length;

    Random number = new Random();

    for(int i = 0; i < size; i++)
    {
        collection[i] = number.NextDouble() + number.Next(minVal, maxVal);
    }
}

// Печатаем массив
void PrintArray(double[] assamblage)
{
    int length = assamblage.Length;
    int i = 0;

    while (i < length)
    {
        Console.Write($"{assamblage[i]} ");
        i++;
    }

}

void GetDifference(double[] collection)
{
    int size = collection.Length;
    int i = 0;
    double min = 0;
    double max = 0;

    if(collection[ i ] >= collection[ i + 1 ])
    {
        min = collection[ i + 1 ];
        max = collection[ i ];
    }

    else
    {
        min = collection[ i ];
        max = collection[ i + 1 ];
    }

    for(i = 1;  i < size; i++)
    {
        if(min >= collection[i])
        {
            min = collection[i];
        }

        else if(max < collection[i])
        {
            max = collection[i];
        }
    }
    
    double difference = max - min;
    Console.WriteLine();
    Console.WriteLine($"min = {min}");
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine();
    Console.WriteLine($"Difference = {difference}");

    

}

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

// Задаём размер массива!
Console.Write("Enter a number that set a size of array.");
Console.WriteLine();
int sizeFoArray = GetNumber();
double[] array = new double[sizeFoArray ];

// Задаём минимальное возможное значение в массиве!
Console.WriteLine("Enter a min value of numbers.");
int inputMinValueOfArray = GetNumber();

// Задаём максимальное возможное значение в массиве!
Console.WriteLine("Enter a max value of numbers.");
int inputMaxValueOfArray = GetNumber();

// Заполняем массив случайными числами и выводим его еа экран
Console.WriteLine();
GetArray(array, inputMinValueOfArray, inputMaxValueOfArray);

Console.WriteLine();

// Выводим массив на экран!
Console.Write("The array = [ ");
PrintArray(array);
Console.Write("]");

// Выводим разницу между макс и мин значениями массива
Console.WriteLine();
GetDifference(array);

