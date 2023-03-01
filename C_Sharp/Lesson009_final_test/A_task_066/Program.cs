/* 

Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке 
от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.Clear();

void GetRange(int firstNum, int lastNum)
{
    int sum = 0;

    
    int end = lastNum;

    Console.Write("Промежуток натуральных элементов = { ");

    for (int start = firstNum; start <= end; start++)
    {
        Console.Write($"{start}, ");
        sum += start;
        
    }
    Console.WriteLine("}");

    Console.WriteLine("");

    Console.WriteLine($"Cумма натуральных элементов в промежутке = {sum}");

}

// Вводим число:
int GetNumber(string mess)
{
    int resultNumber = 0;

    while(true)
    {
        Console.Write(mess);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber >= 0)
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

int inputFirstNum = GetNumber("Введите минималное число в промежутке: ");

int inputLastNum  = GetNumber("Введите максималное число в промежутке: ");

GetRange(inputFirstNum, inputLastNum );