/*
Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите № дня недели:  ");

string input_number = Console.ReadLine();
int a_number_of_day = Convert.ToInt32(input_number);

Console.Write("Будет ли он выходным? ");

if (1 <= a_number_of_day && a_number_of_day <= 5)

{
    Console.Write("Нет!");
}

else if (6 <= a_number_of_day && a_number_of_day <= 7)

{
    Console.Write("Да!");
}

else

{
    Console.Write("Это число, вообще, не может быть днём недели!");
}

