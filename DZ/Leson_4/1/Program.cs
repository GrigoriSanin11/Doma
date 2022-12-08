// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// программа принимает число и выдает количество символов 

int NumbCount(int n)

{
    int count = 0;

    while (n > 0)
    {
        n = n / 10;  // n автоматом фиксируется в int NumbCount(int n)
        count ++;
    }
    return count;
}


Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));

