// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(SeriesNum(n, m));

int SeriesNum(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{SeriesNum(n, m + 1)}, ");
    return m;
}
