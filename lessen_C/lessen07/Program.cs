List<List<int>> list = new List<List<int>>();

list.Add(new List<int>());
list[0].Add(new Random().Next(10));
list[0].Add(new Random().Next(10));
list[0].Add(new Random().Next(10));

list.Add(new List<int>());
list[1].Add(new Random().Next(10));
list[1].Add(new Random().Next(10));
list[1].Add(new Random().Next(10));
list[1].Add(new Random().Next(10));
list[1].Add(new Random().Next(10));
list[1].Add(new Random().Next(10));

list.Add(new List<int>());
list[2].Add(new Random().Next(10));
list[2].Add(new Random().Next(10));

foreach (var item in list)
{
    foreach (var i_item in item)
        Console.Write($"{i_item} ");
    Console.WriteLine();
}


// /*  **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12         */

// int m = 4, n = 6;

// int[,] array = new int[m, n];

// int sum = 0;

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// int min = m < n ? m : n;

// for (int i = 0; i < min; i++)
// {
//     sum += array[i, i];
// }

// Console.Write($"Sum = {sum}");


// /*  **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1  4 7 2
// 5 81 2 9
// 8  4 2 4         */

// int m = 3, n = 4;

// int[,] array = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i % 2 != 0 && j % 2 != 0)
//         {
//             array[i, j] *= array[i, j];
//         }
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }


// using System;
// *  **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в 
// массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 */

// int m = 10, n = 10;

// int[,] array = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = i + j;
//         Console.Write($"{i}{j} ");
//     }
//     Console.WriteLine();
// }

// int m, n;
// Console.Write("Введите первую размерность : ");
// int.TryParse(Console.ReadLine()!, out m);
// Console.Write("Введите вторую размерность : ");
// int.TryParse(Console.ReadLine(), out n);

// List<List<int>> list = new List<List<int>>();
// for (int i = 0; i < m; i++)
// {
//     list.Add(new List<int>());
//     for (int j = 0; j < n; j++)
//     {
//         list[i].Add(new Random().Next(10));
//     }
// }

// foreach (var item in list)
// {
//     foreach (var i_item in item)
//     {
//         Console.Write($"{i_item} ");
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < m; i++)
// {
//     for (int k = 0; k < n; k++)
//     {
//         Console.Write($"{list[i][k]} ");
//     }
//     Console.WriteLine();
// }

/* **Задача 46:** Задайте двумерный массив размером m×n, заполненный 
случайными целыми числами.
m = 3, n = 4.

1 4 8 19
5 -2 33 -2
77 3 8 1         */

// int m = 3, n = 4;

// int[,] array = new int[m, n];

// int[,] array1 = CreateArray(m, n);
// void CreateArray(ref int[,] _array)
// {
//     for (int i = 0; i < _array.GetLength(0); i++)
//     {
//         for (int j = 0; j < _array.GetLength(1); j++)
//         {
//             _array[i, j] = new Random().Next(10);
//             Console.Write($"{_array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateArray(int _m, int _n)
// {
//     int[,] _array = new int[_m, _n];
//     for (int i = 0; i < _m; i++)
//     {
//         for (int j = 0; j < _n; j++)
//         {
//             _array[i, j] = new Random().Next(10);
//             Console.Write($"{_array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return _array;
// }


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
