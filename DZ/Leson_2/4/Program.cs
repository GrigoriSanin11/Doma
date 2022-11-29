Console.WriteLine("Введите  число соответствующее дню недели");
int n = int.Parse(Console.ReadLine());

if (n <= 5)
{
    Console.WriteLine("Будний день");
}    
if (n > 5 && n <= 7)
{
    Console.WriteLine("Выходной день");
}    
    if (n > 7)
{
    Console.WriteLine("Х***ю пишешь");
}