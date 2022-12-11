//Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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

String poisk (int[] arr, int num)

{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        
            return"Da";
        
       
    }
    return "No";

}



int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(poisk(arr_1, int.Parse(Console.ReadLine())));

