//  Задача 1: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void EightMass()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());


    if (a < b + c & b < a + c & c < a + b)
        Console.WriteLine("yes");

    else
        Console.WriteLine("No");

}

EightMass();