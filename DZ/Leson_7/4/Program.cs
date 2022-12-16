//Задача 3: Задайте двумерный массив. Найдите сумму элементов
//главной диагонали.
//Например, задан массив:
//1 4 7
//5 9 2
//8 4 2
//Сумма элементов главной диагонали: 1+9+2 = 12




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



 int end (int[,] mass)
{

    int summ = 0;

    for (int i = 0; i < mass.GetLength(0); i += 1)
    {
        for (int j = 0; j < mass.GetLength(1); j += 1)
        {
            if (i == j)
            {
                summ += mass[i, j];
                
            }
        }    
               
    }
    Console.WriteLine(summ);
    return summ;
}




int[,] mass = new int[7, 11];



arr(mass);
Print(mass);
Console.WriteLine();
end(mass);

