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
        }
    }
    return  resultNumber;
}
// Вводим число в программу!

int GetPolinomial(int number)
{
    int fifthNumber = number / 10000;
    int fourthNumber = number / 1000 - fifthNumber*10;

    int secondNumber = (number - (number/100)*100) / 10;
    int firstNumber = (number - (number/10)*10);
    
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
//Находим полином!

int x = GetNumber($"Enter a five-digit number!");
// Необходимое нам число!
Console.WriteLine(GetPolinomial(x));










