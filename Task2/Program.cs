// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

class Program
{
    static uint Ack(uint m, uint n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        uint m = Convert.ToUInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        uint n = Convert.ToUInt32(Console.ReadLine());

        uint result = Ack(m, n);
        Console.WriteLine($"Ack({m}, {n}) = {result}");
    }
}