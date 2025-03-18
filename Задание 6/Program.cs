using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите признак транспортного средства (a - автомобиль, b - велосипед, m - мотоцикл, c - самолет, p - поезд): ");
        char vehicleType = Console.ReadLine()[0];

        int maxSpeed;

        switch (vehicleType)
        {
            case 'a':
                maxSpeed = 150; 
                break;
            case 'b':
                maxSpeed = 25; 
                break;
            case 'm':
                maxSpeed = 180;
                break;
            case 'c':
                maxSpeed = 900; 
                break;
            case 'p':
                maxSpeed = 200;
                break;
            default:
                Console.WriteLine("Неверный признак транспортного средства.");
                return;
        }

        Console.WriteLine($"Максимальная скорость: {maxSpeed} км/ч");
    }
}