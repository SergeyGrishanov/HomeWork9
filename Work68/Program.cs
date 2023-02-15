// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.WriteLine("Введите положительное число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine()!);

int Ack(int m, int n)
{
    if (m == 0) return n + 1;

    if (m > 0 && n == 0) return Ack(m - 1, 1);

    else return Ack(m - 1, Ack(m, n - 1));
}

Console.WriteLine($"A({m}, {n}) = {Ack(m, n)}");