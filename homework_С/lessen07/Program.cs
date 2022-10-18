using System;
using System.Security.Cryptography;
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3; int n = 4;
double minValue = -10;
double maxValue = 10;

double[,] array = new double[m, n];
array = CreateArray(array, minValue, maxValue);
PrintArray(array);

double[,] CreateArray(double[,] _array, double _minValue, double _maxValue)
{
    //double[,] _array = new double[_m, _n];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int z = 0; z < _array.GetLength(1); z++)
        {
            _array[i, z] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue), 1);
        }
    }
    return array;
}

void PrintArray(double[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int z = 0; z < _array.GetLength(1); z++)
        {
            Console.Write($"{array[i, z]} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4   17 -> такого числа в массиве нет

// int[,] array = {
//     { 1, 4, 7, 2},
//     { 5, 9, 2, 3},
//     { 8, 4, 2, 4}
// };

// PrintArray(array);
// int x; int y;
// Console.Write("Введите  проверочную позицию X : ");
// int.TryParse(Console.ReadLine()!, out x);
// Console.Write("Введите  проверочную позицию Y : ");
// int.TryParse(Console.ReadLine()!, out y);
// FindNumber(array, x, y);

// void FindNumber(int[,] _array, int _x, int _y)
// {
//     if (_array.GetLength(0) < _x || _array.GetLength(1) < _y)
//     {
//         Console.Write($"Такого элемента нет");
//     }
//     for (int i = 0; i < _array.GetLength(0); i++)
//     {
//         for (int z = 0; z < _array.GetLength(1); z++)
//         {
//             if (_x == i && _y == z)
//             {
//                 Console.Write($"Число = {_array[i, z]} ");
//                 return;
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] _array)
// {
//     for (int i = 0; i < _array.GetLength(0); i++)
//     {
//         for (int z = 0; z < _array.GetLength(1); z++)
//         {
//             Console.Write($"{array[i, z]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] array = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
// };

// FindAverage(array);

// void FindAverage(int[,] _array)
// {
//     for (int i = 0; i < _array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int z = 0; z < _array.GetLength(0); z++)
//         {
//             //int[] Array
//             //Console.Write($"{_array[z, i]} ");
//             sum += _array[z, i];
//         }
//         //Console.WriteLine();
//         double num = sum / _array.GetLength(0);
//         //Console.Write($"{num} ");
//         Console.Write($" {Math.Truncate(10 * (sum / _array.GetLength(0))) / 10} ");
//     }
// }