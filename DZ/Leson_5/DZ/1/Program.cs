﻿//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{

    int[] mass = new int[size];

    for (int i = 0; i < size; i++)
        mass[i] = new Random().Next(100, 999);

    return mass;
}

int End(int[] mass)

{
    int count = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        
            count += 1;
    }
    return count;
    

}
int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(End(arr_1));
