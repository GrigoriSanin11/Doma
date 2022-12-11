//Задача 1: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] EightMass(int size)
{

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);

    return arr;
}
void massiv (int [] arr_1)
{
    for (int i = 0; i < arr_1.Length; i++)

        if (arr_1[i] != 0)
        {    
            arr_1[i] = arr_1[i] * -1;
        }

    
}
int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
massiv(arr_1);
Print(arr_1);