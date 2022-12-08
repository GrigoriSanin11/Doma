// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine(Summ(int.Parse(Console.ReadLine())));

int Summ(int num)
{
    int n= 0;
    while (num>0);
    {
        n += num % 10;
        num /= 10;
    }
    return n;
}