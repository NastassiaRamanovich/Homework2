// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[]array = new int[8];

// void fillArray(int[] array){
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next(0,2);
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

// fillArray(array);

int[] Array (int number){
    int[] arr = new int[number];
    Random rand = new Random();
    
    for (int i = 0; i < number; i++){
        arr[i] = rand.Next(2);
        Console.Write($"{arr[i]} ");        
    }
    
    return arr;
}

Array(8);