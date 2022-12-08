// See https://aka.ms/new-console-template for more information

// массив заполненый 0 и 1 в случайном порядке

void Massiv(int n)
	{
	    int[] array = new int[n];
	    for (int i = 0; i < n; i++)
	    {
	        array[i] = new Random().Next(2);
	        Console.Write($"{array[i]}, ");
	    }   
	}
	
	Console.WriteLine("Введите число:");
	Massiv(int.Parse(Console.ReadLine()));