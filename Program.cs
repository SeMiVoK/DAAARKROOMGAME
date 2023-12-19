namespace DARKROOMGAME;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Побег из комнаты'!");
        Console.Write("Пожалуйста, введите ваше имя: ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"Привет, {playerName}! Вы просыпаетесь в темной комнате.");

        bool hasKeyFromSafe = false;
        bool hasScrewdriver = false;
        bool hasKeyFromDoor = false;

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1) Посмотреть под кровать.");
            Console.WriteLine("2) Посмотреть на тумбочку.");
            Console.WriteLine("3) Посмотреть в шкаф.");
            Console.WriteLine("4) Посмотреть на вентиляцию.");
            Console.WriteLine("5) Попробовать открыть дверь.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вы посмотрели под кровать и не нашли ничего полезного.");
                    break;
                case "2":
                    Console.WriteLine("Вы посмотрели на тумбочку и нашли ключ от сейфа.");
                    hasKeyFromSafe = true;
                    break;
                case "3":
                    Console.WriteLine("Вы посмотрели в шкаф и нашли сейф, а в сейфе лежит отвертка.");
                    hasScrewdriver = true;
                    break;
                case "4":
                    if (hasScrewdriver)
                    {
                        Console.WriteLine("Вы использовали отвертку, чтобы открыть вентиляцию, и нашли ключ от двери.");
                        hasKeyFromDoor = true;
                    }
                    else
                    {
                        Console.WriteLine("Вентиляция заперта. Вам нужна отвертка.");
                    }
                    break;
                case "5":
                    if (hasKeyFromDoor)
                    {
                        Console.WriteLine("Поздравляем, вы открыли дверь и сбежали из комнаты!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Дверь заперта. Вам нужен ключ.");
                    }
                    break;
                default:
                    Console.WriteLine("Пожалуйста, выберите действие, введя номер из списка.");
                    break;
            }
        }
    }
}