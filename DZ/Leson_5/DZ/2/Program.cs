//Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

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
        mass[i] = new Random().Next(1, 10);

    return mass;
}

int End(int[] mass)

{
    int count = 0;
    int summ = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (count % 2 == 0)
            summ = summ + mass[i];
            count ++;
    }        
    return summ;
    

}
int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(End(arr_1));
