//  Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

int GetSumNum(int m, int n)
{
    if (m == n) return n;
    else return n + GetSumNum(m, n - 1);
    
}

Console.WriteLine($"Сумма чисел от {n} до {m} равна {GetSumNum(n, m)}");