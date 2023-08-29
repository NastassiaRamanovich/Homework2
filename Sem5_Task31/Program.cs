// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

int[]array = new int[12];
int SumPositive = 0;
int SumNegative = 0;

fillArray(array);

foreach (int number in array)
{
    if (number > 0)
    {
        SumPositive += number;
    }
    else
    SumNegative += number;
}
Console.WriteLine($"Сумма положительных - {SumPositive} и сумма отрицательных - {SumNegative}");

void fillArray(int[] array){
  for (int i = 0; i < array.Length; i++)
  {
        array[i] = new Random().Next(-9, 10);       
  }
  Console.WriteLine(String.Join(" ", array)); 
}