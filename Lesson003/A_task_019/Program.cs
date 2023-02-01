/*

Задача 19

Напишите программу, которая принимает 
на вход пятизначное число и проверяет, 
является ли оно палиндромом.

*/

int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }

        else
        {
            Console.WriteLine("Have entered a number or an incorrect number. Please, repeat the enter!");
            break;
        }
    }
    return  resultNumber;
}

int GetPolinomial(int number)
{
    int fifthNumber = number / 10000;
    int fourthNumber = number / 1000 - fifthNumber*10;

    int secondNumber = (number - (number/100)*100) / 10;
    int firstNumber = (number - (number/10)*10);
    
    Console.WriteLine($"5 - {fifthNumber}");
    Console.WriteLine($"4 - {fourthNumber}");
    Console.WriteLine($"2 - {secondNumber}");
    Console.WriteLine($"1 - {firstNumber}");

    if (fifthNumber == firstNumber && fourthNumber == secondNumber)
    {
        Console.WriteLine("The number is a polonomial!");
    }

    else
    {
        Console.WriteLine("The number isn't a polonomial!");
    }
    return number; 

}

int x = GetNumber($"Enter a number!");
// Необходимое нам число!
Console.WriteLine(GetPolinomial(x));










