﻿//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.


void nab(int a, int b)
{
    if ( a > b ) return;
    {
        if (a % 2 != 1)
        {
        
            Console.Write($"{a} ");

            nab (a + 2, b );
        }

        else 
        {
            a ++ ; 
            Console.Write($"{a} ");
            nab(a + 2, b );
            
        }    

    }

}

nab(11, 32);
