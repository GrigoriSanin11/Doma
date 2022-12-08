//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

Double N(int a, int b)
{
    double C = 1;
    int D = Math.Abs(b);
    for (int i = 1; i <= D; i++)
    {
    if (b > 0)
        C *= a;
    else
        C /= a;
    }
return C;

}
Console.WriteLine("введите число:");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите lheujt число:");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine(N(n1, n2));
