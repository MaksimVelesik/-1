using System;

    class Program
    {
    static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isTwoDigit = number >= 10 && number <= 99; 
        bool isEven = number % 2 == 0;

        if (isTwoDigit && isEven) 
        {
            Console.WriteLine("Данное число является четным двузначным числом.");
        }
        else
        {
            Console.WriteLine("Данное число не является четным двузначным числом.");
        }
    }
}