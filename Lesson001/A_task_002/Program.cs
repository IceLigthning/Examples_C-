/*
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число 
большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();

Console.Write("Enter a first namber: ");
string inputNumber_a = Console.ReadLine();
int number_a = Convert.ToInt32(inputNumber_a);

Console.Write("Enter a second namber: ");
string inputNumber_b = Console.ReadLine();
int number_b = Convert.ToInt32(inputNumber_b);

Console.WriteLine();

if (number_a > number_b)
{
    int max = number_a;
    Console.WriteLine($"Max = {max}");
}

else
{
    int max = number_b;
    Console.WriteLine($"Max = {max}");
}