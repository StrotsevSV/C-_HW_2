// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        string input = Console.ReadLine();

        char thirdDigit = ThirdDigit(input);

        if (thirdDigit != '\0')
        {
            Console.WriteLine("Третья цифра: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }

    static char ThirdDigit(string number)
    {
        if (number.Length == 3)
        {
            return number[2];
        }
        else
        {
            return '\0';
        }
    }
}