//Задача 2: Задайте двумерный массив. Найдите элементы, у которых
//обе позиции чётные, и замените эти элементы на их квадраты.


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

 void end (int[,] mass)
{
    for (int i = 1; i < mass.GetLength(0); i += 2)
    {
        for (int j = 1; j < mass.GetLength(1); j += 2)
        {
            mass[i, j ] *= mass[i, j ] ;
            
            
        }    
               
    }
    
}


int[,] mass = new int[3, 4];

arr(mass);
Print(mass);
Console.WriteLine();
end(mass);
Print(mass);
