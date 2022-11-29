Console.WriteLine("Введите  число");
string n = Console.ReadLine();
int simvol = n.ToString().Length;

Console.WriteLine(n);

if (simvol >= 3) 
{
    Console.WriteLine(n[2]);
}
else Console.WriteLine("Третьего символа нет");