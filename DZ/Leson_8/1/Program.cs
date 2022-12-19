//Задача 2: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.
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
    if (mass.GetLength(0) == mass.GetLength(1) )
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                ( mass[i , j],mass[j , i]) = (mass[j , i], mass[i , j]);

            }

        }
    }
    else 
    {Console.WriteLine(888);}
    
}

int[,] mass = new int[5, 7];

arr(mass);
Print(mass);
Console.WriteLine();
Zamen(mass);
Print(mass);

