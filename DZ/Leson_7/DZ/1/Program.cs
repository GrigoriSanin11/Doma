//Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

void Print(double[,] mass)
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



void arr (double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            
            mass[i, j ] = Convert.ToDouble(new Random().Next(-100, 100 )) / 10;

        }
    
    }
}
double[,] mass = new double[3, 4];

arr(mass);
Print(mass);

