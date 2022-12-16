//Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1


void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {    
        for (int j = 0; j < mass.GetLength(1); j++)
        {
        Console.Write($"{mass[i, j ],6 } ");
        }
        Console.WriteLine();
    }
}



void arr (int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            
            mass[i, j ] = new Random().Next(-100, 100 );

        }
    
    }
}
int[,] mass = new int[3, 4];

arr(mass);
Print(mass);

