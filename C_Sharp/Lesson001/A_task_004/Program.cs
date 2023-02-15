/*
Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих 
чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.Write("Enter fiest number: ");
string inputFirstNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputFirstNumber);

Console.Write("Enter second number: ");
string inputSecondNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(inputSecondNumber);

Console.Write("Enter third number: ");
string inputThirdNumber = Console.ReadLine();
int thirdNumber = Convert.ToInt32(inputThirdNumber);

Console.WriteLine();

if(firstNumber > secondNumber)
{
    int max = firstNumber;
    if(max > thirdNumber)
    {
        Console.WriteLine($"Max = {max}");
    }

    else
    {
        max = thirdNumber;
        Console.WriteLine($"Max = {max}");
    }
}
else
{
    int max = secondNumber;
    if(max > thirdNumber)
{
    Console.WriteLine($"Max = {max}");
}

else
{
    max = thirdNumber;
    Console.WriteLine($"Max = {max}");
}

}

