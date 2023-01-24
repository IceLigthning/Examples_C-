/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что 
третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
int GetNumber(int a_count)
{
    int result = a_count/100-(a_count/1000)*10;
    return result;
}

Console.WriteLine("Введите любое число:");
string input_number = Console.ReadLine();
int transit_number = Convert.ToInt32(input_number);
int number = GetNumber(transit_number);

if (number == 0) 
{
    Console.WriteLine("третьей цифры нет");
}
else {
    Console.WriteLine($"Вывод третьей цифры числа {transit_number} - это: {number}");
}




