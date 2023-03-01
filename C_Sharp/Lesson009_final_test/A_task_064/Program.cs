
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
*/

Console.Clear();

string GetRange(int number, int endRange = 10)
{
    if(number <= endRange)
    { 
        
        return $"{endRange}, " + GetRange(number, endRange -1);
    
    }
    
    else
    { 
        
        return String.Empty;
    
    }
    

}

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

int inputNum = GetNumber("Введите конечное число ряда: ");
int number = 1;

Console.Write(GetRange(number, inputNum));