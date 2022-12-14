
//Задача 3: Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] fib(int size)
{

    int[] mass = new int[size];
    mass[0]= 0;
    mass[1]= 1;

    for (int i = 2; i < size ; i++)
        mass[i] =  mass[i-1] + mass[i-2];
    return mass;
    Console.Write(mass);

}
int[] arr_1 = fib(int.Parse(Console.ReadLine()));

Print(arr_1);
