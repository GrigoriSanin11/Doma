//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
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
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum = sum + mass[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
Console.WriteLine(indexLine);
}

int[,] mass = new int[5, 7];

arr(mass);
Print(mass);
Console.WriteLine();
Zamen(mass);

