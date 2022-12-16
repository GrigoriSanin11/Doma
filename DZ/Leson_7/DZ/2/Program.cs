//Задача 2: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание




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


void red (int[,] mass, int namb_1, int namb_2)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i == namb_1 & j == namb_2 )
            {
                Console.WriteLine(mass[i , j ]);
                
            }
        }
            
    }
}



int[,] mass = new int[5, 4];

arr(mass);
Print(mass);
Console.WriteLine();
red(mass, int.Parse(Console.ReadLine()),
          int.Parse(Console.ReadLine()));
