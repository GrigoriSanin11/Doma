//принимает N выдает произведение от 1 до N

Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));

int Proiz(int n)
{
    int all_sum = 1;
    for (int i = 1; i <= n; i++)
    {
        all_sum *= i;

    }
    return all_sum;
}