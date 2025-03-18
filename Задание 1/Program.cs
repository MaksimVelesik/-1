using System;

class Program
 {
   static void Main()
    {
        Console.WriteLine("Введите расстояние в метрах: ");
        double meters = Convert.ToDouble (Console.ReadLine());

        int kilometrs = (int)(meters / 1000);

        Console.WriteLine($"Количество полных километров: {kilometrs}");
    }
}