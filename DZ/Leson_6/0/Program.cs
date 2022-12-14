//Задача 1: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

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
        mass[i] = new Random().Next(0, 100);

    return mass;
}


void RevMas(int[] arr_1)
{

    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1 ]) = (arr_1[size - i - 1], arr_1[i]); 

}


int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));

Print(arr_1);
RevMas(arr_1);
Print(arr_1);