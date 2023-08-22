// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x,y,a,b"); 

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


int[] array = new int[2];
array[0] = x;
array[1] = y;
int [] array1 = new int[2];
array1[0] = a;
array1[1] = b;

int f = (a - x) * (a - x) + (b - y) * (b - y);

double result = Math.Round(Math.Sqrt(f),2);

Console.WriteLine(result);




