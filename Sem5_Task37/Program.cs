using System;

public class Answer
{
    public static void Main(string[] args)
    {
        // Создаем массив из 123 случайных чисел
        Random random = new Random();
        int[] array = new int[123];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 1000);
        }

        // Находим количество элементов массива, значения которых лежат в отрезке [10,99]
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 10 && array[i] <= 99)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99]: " + count);
    }
}
