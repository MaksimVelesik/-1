using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        string n = Console.ReadLine();

        Console.Write("Введите цифру k: ");
        char k = Console.ReadLine()[0];

        if (!char.IsDigit(k))
        {
            Console.WriteLine("Ошибка: введенная символ не является цифрой.");
            return;
        }

        int count = 0;
        foreach (char digit in n)
        {
            if (digit == k)
            {
                count++;
            }
        }

        Console.WriteLine($"Цифра {k} входит в число {n} {count} раз(а).");
    }
}