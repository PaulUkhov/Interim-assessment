// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program
{
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " "); // Выводим текущий элемент массива
            PrintArrayReversed(arr, index - 1); // Рекурсивный вызов для следующего элемента
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReversed(arr, arr.Length - 1); // Начинаем с последнего индекса массива
    }
}
