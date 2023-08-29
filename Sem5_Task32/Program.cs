// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[]array = new int[4];

fillArray(array);

for (int i = 0; i < array.Length; i++)
{
   
        array[i] = array[i] * (-1);
    
}
Console.WriteLine(String.Join(" ", array));
void fillArray(int[] array){
  for (int i = 0; i < array.Length; i++)
  {
        array[i] = new Random().Next(-9, -1);       
  }
  Console.WriteLine(String.Join(" ", array)); 
}
