/*
Задача 21

Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3, 6, 8); B (2, 1,-7), -> 15.84
A (7,-5, 0); B (1,-1, 9), -> 11.53

*/


int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
                
    }
    return  resultNumber;
}
//Вводим пятизначное число из терминала

double GetCoordinats (double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenghtVector = (Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb)));

    return lenghtVector;
}
//Выводим расстояние между точками

Console.WriteLine("Ввод координаты для первой точки");

int x1 = GetNumber("Ввод координаты X для первой точки, которая не равна 0: ");
int y1 = GetNumber("Ввод координаты Y для первой точки, которая не равна 0: ");
int z1 = GetNumber("Ввод координаты Z для первой точки, которая не равна 0: ");

Console.WriteLine("Ввод координаты для второй точки");

int x2 = GetNumber("Ввод координаты X для второй точки, которая не равна 0: ");
int y2 = GetNumber("Ввод координаты Y для второй точки, которая не равна 0: ");
int z2 = GetNumber("Ввод координаты Z для второй точки, которая не равна 0: ");

double Vector = GetCoordinats (x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Длина вектора {Vector}");



