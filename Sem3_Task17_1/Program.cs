// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int[] array = new int[2];
array[0] = x;
array[1] = y;

Console.WriteLine("Введите координаты X и Y");

for (i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвёртая четверть");
}
else
{
    Console.WriteLine("x = 0, y = 0");
}
