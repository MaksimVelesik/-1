using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите цифру X: ");
        char X = Console.ReadLine()[0];
        Console.Write("Введите цифру Y: ");
        char Y = Console.ReadLine()[0];

        Console.WriteLine("Цикл while:");
        int i = A;
        while (i <= B)
        {
            if (i % 10 == (X - '0') || i % 10 == (Y - '0'))
            {
                Console.WriteLine(i);
            }
            i++;
        }

        Console.WriteLine("Цикл do while:");
        i = A; 
        do
        {
            if (i % 10 == (X - '0') || i % 10 == (Y - '0'))
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= B);

        Console.WriteLine("Цикл for:");
        for (int j = A; j <= B; j++)
        {
            if (j % 10 == (X - '0') || j % 10 == (Y - '0'))
            {
                Console.WriteLine(j);
            }
        }
    }
}