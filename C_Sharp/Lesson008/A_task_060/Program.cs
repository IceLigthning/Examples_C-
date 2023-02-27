/*

Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

Console.Clear();

//Метод для ввода числа с консоли:

int GetNumber(string mess)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(mess);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
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

// Метод заполнения массива:
int[,,] GetMatrix(int x, int y, int z)
{
    int[,,] matr= new int[x, y, z];

    Random value = new Random();

    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                matr[i,j,k] = value.Next(0, 11);
                
            }
            
        }
    
    }
    return matr;

}

// Метод печати массива:
void GetPrint(int[,,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                
                Console.WriteLine($"{matr[i,j,k]}    ({i}, {j}, {k})");

            }


        }

        
    }

}



// Задаём размер массива:
int x = GetNumber("Введите число X: ");
int y = GetNumber("Введите число Y: ");
int z = GetNumber("Введите число Z: ");
int[,,] matrix = GetMatrix(x, y, z);

GetPrint(matrix);

