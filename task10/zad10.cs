// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трёхзначное число: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 100 && number <= 999)
        {
            int secondDigit = (number / 10) % 10;
            Console.WriteLine("Вторая цифра числа: " + secondDigit);
        }
        else
        {
            Console.WriteLine("Ошибка: неверно введено трёхзначное число.");
        }
    }
}