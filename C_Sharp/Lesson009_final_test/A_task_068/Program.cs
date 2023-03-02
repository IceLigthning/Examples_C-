/*

Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. Даны 
два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

Console.Clear();

// Ввод числа:
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

// Объявляем аргументы для ввода в
int inputM = GetNumber("Введите конечное число << m >>: ");
int inputN = GetNumber("Введите конечное число << n >>: ");


// Создаём функцию
int GetAkkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }

    else if(m > 0 && n == 0)
    {
        return GetAkkerman(m - 1 , 1);
    }

    else if(m > 0 && n > 0)
    {
        return GetAkkerman(m - 1, GetAkkerman(m , n - 1));
    }

    else
    {
        return Convert.ToInt32(String.Empty);
    }

}

// Метод вызоыва функции
void Akker(int M, int N)
{
    Console.Write(GetAkkerman(M, N));
};

// Вызываем функцию
Akker(inputM, inputN);


