﻿//Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!); 
int count = a % 2;

if (count == 0)
{
    Console.Write("{a} Четное ");
}
else 
{
    Console.Write("{a} Не четное ");
}