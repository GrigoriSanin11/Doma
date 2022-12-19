//Задача 1: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.
void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j],6} ");
        }
        Console.WriteLine();
    }
}



void arr(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(-100, 100);
        }

    }
}

void Zamen(int[,] mass)
{
    int P = new() ;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            ( mass[0 , j], mass[mass.GetLength(0) - 1, j]) = (mass[mass.GetLength(0) - 1, j], mass[0 , j]);

        }

    }
}

int[,] mass = new int[5, 5];

arr(mass);
Print(mass);
Console.WriteLine();
Zamen(mass);
Print(mass);

