﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

if (a / b == b)
{
    Console.WriteLine("da");
}
else {
    Console.WriteLine("net");
}