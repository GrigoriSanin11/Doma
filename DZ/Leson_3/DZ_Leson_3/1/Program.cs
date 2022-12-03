
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine());
String a = n.ToString();

if (a[0] == a[4] && a[1] == a[3])
{
    Console.WriteLine("Палиндромом");
}
else Console.WriteLine("Не палиндромом");
