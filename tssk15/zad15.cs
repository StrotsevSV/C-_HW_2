﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

     if (dayNumber == 6 || dayNumber == 7)
     {
     Console.WriteLine("Выходной день");
     }
     else if (dayNumber >= 1 && dayNumber <= 5)
     {
    Console.WriteLine("Рабочий день");
     }
     else
     {
     Console.WriteLine("Неверный ввод");
     }