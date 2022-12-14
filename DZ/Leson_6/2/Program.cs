//Задача 2: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

void big()
{
    int a = int.Parse(Console.ReadLine());
    string boos = Convert.ToString(a, 2);
    Console.WriteLine(boos);
}

big();