// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void Second_Digit(int a)
{
    if (a.ToString().Length == 3)
    {
        a = a % 100 / 10;
        Console.WriteLine("Вторая цифра числа:" + " " + a);
    }
    else 
    {
        Console.WriteLine("Число не трёхзначное");
    }
}


Console.WriteLine("Введите число: "); // ввод числа пользователя
int number = int.Parse(Console.ReadLine()); // считать данные пользователя
Second_Digit(number);
Second_Digit(102);