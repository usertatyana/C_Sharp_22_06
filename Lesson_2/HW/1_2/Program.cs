//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int nov1 = 1000;

if (num > nov1)
{
    nov1 = num % 100;
    int nov2 = nov1 / 10;
    Console.WriteLine($"Третья цифра {nov2}");
}


if (num < 100)
{
    Console.WriteLine($"Нет третьей цифры");
}

if (num > 100 && num < 1000)
{
    int num1 = num % 10;
    Console.WriteLine($"Третья цифра {num1}");
}
