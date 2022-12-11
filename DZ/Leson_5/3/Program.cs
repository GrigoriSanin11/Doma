// Задача 3: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size, int start, int last)
{

    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
        mass[i] = new Random().Next(start, last +1);

    return mass;
}
int end (int[] mass)
{
    int Count = 0;

    for (int i = 0; i < mass.Length; i++)
   {
        if (mass[i] > 10 && mass[i] < 99)
        {
            Count ++;                
        }
   }
   return Count;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);