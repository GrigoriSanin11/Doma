//Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}


double[] Mass(int size, int frome, int to)
{
    double[] arr = new double[size];
    Random new1 = new Random();
    
    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(new1.NextDouble()* (frome + to) - frome, 2);
    return arr;    
}
void DiffMaxMin(double[] arr)
{
    double max1 = arr[0];
    double min1 = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max1 < arr[1])
            max1 = arr[i];

        else if (min1 > arr[i])
            min1 = arr[i];        
    }
    Console.Write($"Max:{max1}, Min: {min1}. ");
    Console.WriteLine($"Dif : {max1} - ({min1}) =  {Math.Round(max1 - min1, 2)}");
}

Double[] arr_1 = Mass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
DiffMaxMin(arr_1);