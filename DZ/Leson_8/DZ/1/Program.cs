//Задача 1: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.

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
Console.WriteLine(" количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[linesVol, columnsVol];

void end(int[,] mass)
{ 
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < mass.GetLength(1) - 1; z++)
            {
                if (mass[i, z] < mass[i, z + 1]) 
                {
                    int temp = 0;
                    temp = mass[i, z];
                    mass[i, z] = mass[i, z + 1];
                    mass[i, z + 1] = temp;
                }
            }
        }
    }
}
arr(mass);
Print(mass);
Console.WriteLine();
end(mass);
Print(mass);