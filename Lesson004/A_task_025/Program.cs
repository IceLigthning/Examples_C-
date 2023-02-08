/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

// Отчиста строки терминала.
Console.Clear();

// Получаем число из терминала.
int GetNumber()
{
    int resultNumber = 0;
    while(true)
    {
        
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        
        else
        
        {
            Console.WriteLine("A number's incorrect!");
        }
    }

    return resultNumber;
}

// Получаем степенное число.
int GetPowerNumber(int first, int second)
{
    int degree = 1;

    for(int inter = 0;   inter < second; inter++)
    {
        degree = degree * first;
    }

    return degree;
}

Console.Write("Enter first number: ");
int getFirstNumber = GetNumber();
// Вводип число.

Console.Write("Enter second number: ");
int getSecondNumber = GetNumber();
// Вводим стпень числа.

int getLast = GetPowerNumber(getFirstNumber, getSecondNumber);

Console.WriteLine("");
Console.WriteLine($"The power number = {getLast} of number {getFirstNumber} with degree {getSecondNumber}.");


