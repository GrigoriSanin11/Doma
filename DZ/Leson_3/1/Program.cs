void Quarters(int x, int y)
{
    if (x == 0 || y == 0 )
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0 )
        Console.WriteLine("1");
    else if (x > 0 && y < 0 )
        Console.WriteLine("4");    
    else if (x < 0 && y > 0 )
        Console.WriteLine("2");
    else if (x < 0 && y < 0 )
        Console.WriteLine("3");
}
Quarters(-1,9);