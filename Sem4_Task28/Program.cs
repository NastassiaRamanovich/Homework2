// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Поиск произведения

int Composition(int number)
{
    int composition = 1;
    for (int i = 1; i <= number; i++)
    {
        composition *= i;
    }
    return composition;
}

string text = "ВВедите число";
int number = Parse(text);
int composition = Composition(number);
Console.WriteLine("Итоговое произведение: " + composition);