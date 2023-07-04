// 3. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!); //a = -6
int count = -a;   //count = 6
while (count != a)
{
    if (a > 0)
        count++;
    else
        count--;
    Console.WriteLine(count);
}
