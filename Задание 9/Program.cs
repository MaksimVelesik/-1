using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите шаг H: ");
        double H = Convert.ToDouble(Console.ReadLine());

        double x = Math.PI / 4; 
        double end = Math.PI / 2; 

        Console.WriteLine("x\t\tcot(x)");
        while (x <= end)
        {
            double y = 1 / Math.Tan(x);
            Console.WriteLine($"{x:F2}\t{y:F4}"); 
            x += H;
        }
    }
}