// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("x > 0, y > 0");
} else if (number == 2)
{
    Console.WriteLine("x < 0, y > 0");
} else if (number == 3)
{
    Console.WriteLine("x < 0, y < 0");
}else if (number == 4)
{
    Console.WriteLine("x > 0, y < 0");
}else
{
    Console.WriteLine("Нужно было указать число от 1 до 4");
}

// альтернативное решение
// Console.WriteLine("Введите четветь (от 1 до 4): ");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num == 1) 
// {
//     Console.WriteLine($"Диапазон X от {1} до {int.MaxValue} ");
//     Console.WriteLine($"Диапазон Y от {1} до {int.MaxValue} ");

// }
// else if (num == 2) 
// {
//     Console.WriteLine($"Диапазон X от {- 1} до {int.MinValue} ");
//     Console.WriteLine($"Диапазон Y от {1} до {int.MaxValue} ");

// }
// else if (num == 3) 
// {
//     Console.WriteLine($"Диапазон X от {- 1} до {int.MinValue} ");
//     Console.WriteLine($"Диапазон Y от {- 1} до {int.MinValue} ");

// }
// else if (num == 4) 
// {
//     Console.WriteLine($"Диапазон X от {1} до {int.MaxValue} ");
//     Console.WriteLine($"Диапазон Y от {- 1} до {int.MinValue} ");

// }
