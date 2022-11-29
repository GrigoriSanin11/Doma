Console.WriteLine("Введите трехзначное число");
string n = Console.ReadLine();


int simvol = n.ToString().Length;

Console.WriteLine(n);

if (simvol == 3) 
{
    Console.WriteLine(n[1]);
}
else Console.WriteLine("Не верное число символов");
