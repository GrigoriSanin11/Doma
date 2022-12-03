// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Ввидите число");

int n = int.Parse(Console.ReadLine());

    int i = 0;
    double pere;
    while (i < n )
   {
        i += 1;
        if (i == (n))
        {
            pere = Math.Pow(i,3);
            Console.WriteLine($"{pere}");
            return;
        }
        else
        {
	        pere = Math.Pow(i,3);
	        Console.Write($"{pere},");
        }
   }
	    
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine(chislo);