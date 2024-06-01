// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

class Program
{
    static void Recursion(int m, int n)
    {
        if (m == n)
        {
            Console.Write(m);
            return;
        }
        if else (m > n)
        {
            Console.Write(m);
        Recursion(m-1, n);
        }
        Console.Write(m);
        Recursion(m+1, n);
    }
    static void Main(string[] args)
    {
        

        Console.WriteLine("Введите начальное число (m):");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конечное число (n):");
        int n = int.Parse(Console.ReadLine());
        Recursion(m, n);
    }

}









