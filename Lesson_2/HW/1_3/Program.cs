﻿// Напишите программу, которая
//выводит случайное трех значное число, и
//удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);


int number1 = number / 100;
int number2 = number % 10;
int result = number1 * 10 + number2;

Console.WriteLine($"{number} -> {result}");

// я мучилась не пойму почему и где ошибка сделала так и то подсмотрела а хотела так
//и запуталась решение на бумаге сделала вроде поняла а вывести не могу
//int number = new Random().Next(100, 1000);
//int RemoveSecond(int number)
//{
//    int number1 = number / 100;
//    int number2 = number % 10;
//    int nov = number1 * 10 + number2;
//    return number;
//}
//int result = RemoveSecond(number);
//Console.WriteLine($"{number} -> {result}");