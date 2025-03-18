using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x >= 1 && x <= 3)
        {
            y = 2 * Math.Pow(x, 2) - 3 * Math.Sin(x);
        }
        else if (x > 3)
        {
            y = 3 * Math.Tan(x);
        }
        else
        {
            Console.WriteLine("x должно быть в диапазоне от 1 до бесконечности.");
            return;
        }

        Console.WriteLine($"Значение y = {y}");
    }
}