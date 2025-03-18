using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите целое число N: ");
        int N = Convert.ToInt32(Console.ReadLine());


        if (N != 0) 
        {
            if (M % N == 0)
            {
                int quotient = M / N;
                Console.WriteLine($"Частное от деления M на N: {quotient}");
            }
            else
            {
                Console.WriteLine("M на N нацело не делится.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
    }
}