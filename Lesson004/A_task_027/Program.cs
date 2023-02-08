/*
Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму 
цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/



// Вводим число.
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

int aNumber = GetNumber();

// Определяем сколько раз число делится на 10;
int GetSizeNumber(int primeNumber)
{
    int count = 0;
    while(primeNumber != 0)
    {
       primeNumber = primeNumber / 10;
       count++;
    }
    return count;
    
}

int aSizeNumber = GetSizeNumber(aNumber);

// Определяем сумму цифр в числе.
int GetSumm()
{ 
    int ten = 1;
    int sum = 0;

    for(int interation = aSizeNumber; interation > 0; interation = interation - 1)
    {   
        
        for(int interat = 0; interat < interation; interat++)
        {
            ten = ten * 10;
            break;
        }

        int unitNumber = (aNumber / (ten/10)) - (aNumber / ten) * 10;
        
        sum = sum + unitNumber;
                       
        Console.WriteLine($"inter {interation} ten {ten} unit {unitNumber}");

    }

    return sum;
}

Console.WriteLine(GetSumm());
