// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

void ArrayRandom(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 6);
    }
    System.Console.WriteLine(string.Join(" ", array));
}

bool ArraySearch(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return true;
        }

    }
    return false;
}

int[] array = new int [15];

ArrayRandom(array);

bool search = ArraySearch(array, 3);

System.Console.WriteLine(search);
