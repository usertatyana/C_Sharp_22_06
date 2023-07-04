// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num > num1 && num > num2)
{
    Console.WriteLine($"Число {num} max");
}
if (num1 > num && num1 > num2)
{
    Console.WriteLine($"Число {num1} max");
}
if (num2 > num && num2 > num1)
{
    Console.WriteLine($"Число {num2} max");
}