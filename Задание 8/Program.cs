using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вещественное число A (-5 <= A <= 5): ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите целое число N (1 <= N <= 10): ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (A < -5 || A > 5 || N < 1 || N > 10)
        {
            Console.WriteLine("Ошибка: введены некорректные значения.");
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            double power = Math.Pow(A, i);
            Console.WriteLine($"{power:F4}");
        }
    }
}