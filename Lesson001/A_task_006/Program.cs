/*
Задача 6: Напишите программу, которая на 
вход принимает число и выдаёт, является 
ли число чётным (делится ли оно на два без 
остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();

Console.WriteLine("Is a number even?");

Console.WriteLine();

Console.Write("Enter a number: ");

string inputNumber = Console.ReadLine();

int number = Convert.ToInt32(inputNumber);

Console.WriteLine();

if(number%2 == 0)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}