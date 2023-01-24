/*
Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого 
числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();

int GetNumber(int a_count)
{
    int second_number = a_count/10-(a_count/100)*10;
    return second_number;
}

Console.WriteLine("Вывод второй цифры из числа 456: ");
Console.WriteLine(GetNumber(456));

Console.WriteLine("Вывод второй цифры из числа 782: ");
Console.WriteLine(GetNumber(782));

Console.WriteLine("Вывод второй цифры из числа 456: ");
Console.WriteLine(GetNumber(918));


Console.WriteLine("Введите число: ");
string first_data = Console.ReadLine();

int number = Convert.ToInt32(first_data);

Console.WriteLine(GetNumber(number));

