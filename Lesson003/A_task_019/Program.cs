/*

Задача 19

Напишите программу, которая принимает 
на вход пятизначное число и проверяет, 
является ли оно палиндромом.

*/

int GetSizenumber(int number)
{
    int count = 0;

    while ( number != 1 )
    {
        number = number / 10;
        count ++;
    }

    return count;

}

string inputNumber = Console.ReadLine();
int inputCount = Convert.ToInt32(inputNumber);

int a = GetSizenumber(inputCount);

Console.Write(a);


