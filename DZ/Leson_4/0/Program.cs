Console.WriteLine(sum(int.Parse(Console.ReadLine())));  // строка для ввода и запоминания числа

int sum(int num)
{
    int allsum = 0;
    for (int i = 1; i <= num; i++)
    {
        allsum = allsum + i;
    }

    return allsum;
}

