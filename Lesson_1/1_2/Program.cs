﻿// 2. Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.

string a = Console.ReadLine()!;
switch (a)
{
    case "1":
    Console.Write("Понедельнтк");
    break;
    case "2":
    Console.Write("Вторник");
    break;
    case "3":
    Console.Write("Среда");
    break;
    case "4":
    Console.Write("Четверг");
    break;
    case "5":
    Console.Write("Пятница");
    break;
    case "6":
    Console.Write("Суббота");
    break;
    case "7":
    Console.Write("Воскресенье");
    break;

    default:
    Console.Write("Такого дня недели нет");
    break;
}