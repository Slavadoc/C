//танцы с бубном
int a =5;
int b = 3;

a= a + b;
b = a-b;
a = a - b;

Console.Write($"{a} {b}");


// int N;
// Console.Write("Enter your number : ");
// int.TryParse(Console.ReadLine()!, out N);

// int[] array = new int[N];

// int a =0;
// int b =1;
// Console.Write($"{a} {b}");
//  for (int i = 2; i < N; i = a + b) //(int i = 2; i < N; i++)
//  {
//     int c = a + b;
//     Console.Write($" {a+b}");
//     a = b;
//     b = c;
//  }


// int a;
// Console.Write("Enter your number : ");
// int.TryParse(Console.ReadLine()!, out a);

// int temp = a;
// string doub = "";

// while (temp > 0)
// {
//     doub += (temp % 2).ToString();
//     temp /=2;
// }

// char[] doubT = doub.ToCharArray();
// Array.Revarse(doubT);
// // for (int i = 0; i < doubT.Length; i++)
// // {
// //     doubT[i];
// // }
// Console.WriteLine(doubT);
//     Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.    */

// int[] array = new int[] { 4, 5, 7 };

// if (TriangleSuccess(array[0], array[1], array[2]))
//     Console.Write($"Треугольник существует");
// else
//     Console.Write($"Треугольник не существует");

// bool TriangleSuccess(int a, int b, int c)
// {
//     return (a + c) > b && (b + c) > a && (a + b) > c;
// }


// /*     **Задача 39:** Напишите программу, которая перевернёт одномерный
//                     массив
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]    */

// int[] array = new int[5];
// int[] array2 = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10);
//     Console.Write($"{array[i]} ");
// }

// for (int i = 0; i < array.Length; i++)
//     array2[i] = array[array.Length - i - 1];

// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
//     Console.Write($"{array2[i]} ");


// /*     **Задача 39:** Напишите программу, которая перевернёт одномерный
//                     массив
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]    */

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10);
//     Console.Write($"{array[i]} ");
// }

// for (int i = 0; i < array.Length / 2; i++)
// {
//     int temp = array[array.Length - i - 1];
//     array[array.Length - i - 1] = array[i];
//     array[i] = temp;
// }

// Console.WriteLine();

// for (int i = 0; i < array.Length; i++){
//     Console.Write($"{array[i]}");
// }


// int[,] array2 = new int[3, 5];

// for (int i = 0; i < array2.GetLength(0); i++) // Строка
// {
//     for (int j = 0; j < array2.GetLength(1); j++) // Столбец
//     {
//         array2[i, j] = new Random().Next(10);
//         Console.Write($"{array2[i, j]} ");
//     }
//     Console.WriteLine();
// }

// foreach (var item in array2)
// {
//     Console.Write($"{item} ");
// }
