// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Parse("Введите число");

int Sumx(int number)
{
    if (number == 0)
    {
        return 1;
    }

    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}

Console.WriteLine(Sumx(number));

// Еще одно решение
// int Print(string text) 
// {
//     Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// static int DigitsNumber (int value){
//     if (value < 0)
//     {
//         value = -value;
//     }

//     string number = value.ToString();
//     return number.Length;
// }
// int number = Print("Введите число");

// Console.WriteLine(DigitsNumber(number));