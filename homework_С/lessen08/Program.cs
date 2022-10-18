// Урок 8. Как не нужно писать код. Часть 2
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = {{1, 4, 7, 2},
//                 {5, 9, 2, 3},
//                 {8, 4, 2, 4}};

// Print(array);
// Console.WriteLine();
// Print(SortInDescending(array));

// int[,] SortInDescending(int[,] _array)
// {
//     for (int i = 0; i < _array.GetLength(0); i++)
//     {
//         int[] _arr = new int[_array.GetLength(1)];
//         for (int z = 0; z < _array.GetLength(1); z++)
//         {
//             _arr[z] = _array[i, z];
//         }
//         _arr = Sort(_arr);
//         for (int z = 0; z < _arr.Length; z++)
//         {
//             _array[i, z] = _arr[z];
//         }
//     }
//     return _array;
// }

// int[] Sort(int[] _arr)
// {
//     for (int i = 0; i < _arr.Length; i++)
//     {
//         for (int z = 0; z < _arr.Length - 1; z++)
//         {
//             if (_arr[z] < _arr[z + 1])
//             {
//                 int temp = _arr[z];
//                 _arr[z] = _arr[z + 1];
//                 _arr[z + 1] = temp;
//             }
//         }
//     }
//     return _arr;//newArray;
// }

// void Print(int[,] _ar)
// {
//     for (int i = 0; i < _ar.GetLength(0); i++)
//     {
//         for (int z = 0; z < _ar.GetLength(1); z++)
//         {
//             Console.Write($"{_ar[i, z]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = {{1, 4, 7, 2},
//                 {5, 9, 2, 3},
//                 {8, 4, 2, 4},
//                 {5, 2, 6, 7}};

// RowSmallestSum(array);

// void RowSmallestSum(int[,] _array)
// {
//     int small = 0;
//     int smallSum = 2147483647;
//     for (int i = 0; i < _array.GetLength(0); i++)
//     {
//         int sum = 0;
//         int[] _arr = new int[_array.GetLength(1)];
//         for (int z = 0; z < _array.GetLength(1); z++)
//         {
//             _arr[z] = _array[i, z];
//         }
//         sum = Sum(_arr);
//         if (smallSum > sum)
//         {
//             smallSum = sum;
//             small = i + 1;
//         }
//     }
//     Console.WriteLine($"Номер строки с наименьшей суммой элементов: {small} строка ");
// }

// int Sum(int[] _ar)
// {
//     int sum = 0;
//     foreach (var item in _ar)
//     {
//         sum += item;
//     }
//     return sum;
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] arrayA = {{2, 4, 1},
//                  {3, 2, 1},
//                  {1, 1, 1}};
// int[,] arrayB = {{3, 4, 0},
//                  {3, 3, 1},
//                  {1, 1, 1}};

int[,] arrayA = {{2, 4},
                 {3, 2}};
int[,] arrayB = {{3, 4},
                 {3, 3}};

int[,] arrayC = Mult(arrayA, arrayB);
Print(arrayC);

int[,] Mult(int[,] _arrayA, int[,] _arrayB)
{
    int[,] matrix = new int[_arrayA.GetLength(0), _arrayB.GetLength(1)];

    for (int x = 0; x < _arrayA.GetLength(0); x++)
        for (int y = 0; y < _arrayB.GetLength(0); y++)
            for (int z = 0; z < _arrayB.GetLength(1); z++)
                matrix[x, z] += _arrayA[x, y] * _arrayB[y, z];
    //matrix[x, z] += _arrayA[x, y] * _arrayB[y, z];
    return matrix;
}

void Print(int[,] _ar)
{
    for (int i = 0; i < _ar.GetLength(0); i++)
    {
        for (int z = 0; z < _ar.GetLength(1); z++)
        {
            Console.Write($"{_ar[i, z]} ");
        }
        Console.WriteLine();
    }
}


препод

int[,,] array = new int[5, 5, 4];

List<int> nums = new List<int>();

for (int i = 0; i < 90; i++)
    nums.Add(i + 10);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            if (nums.Count == 0)
                array[i, j, k] = 0;
            else
            {
                int temp = new Random().Next(nums.Count);
                array[i, j, k] = nums[temp];
                nums.RemoveAt(temp);
            }
        }
    }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = 2, y = 2, z = 2;
// int[,,] array = FillArray(x, y, z);
// Print3Darray(array);

// int[,,] FillArray(int _x, int _y, int _z)
// {
//     int[,,] _array = new int[_x, _y, _z];
//     for (int x = 0; x < _array.GetLength(0); x++)
//     {
//         for (int y = 0; y < _array.GetLength(1); y++)
//         {
//             for (int z = 0; z < _array.GetLength(2); z++)
//             {
//                 int num = new Random().Next(10, 100);
//                 while (FindMatch(_array, num))
//                 {
//                     //Console.Write("While work ");
//                     num = new Random().Next(10, 100);
//                 }
//                 _array[x, y, z] = num;
//             }
//         }
//     }
//     return _array;
// }

// bool FindMatch(int[,,] _ar, int _num)
// {
//     for (int x = 0; x < _ar.GetLength(0); x++)
//     {
//         for (int y = 0; y < _ar.GetLength(1); y++)
//         {
//             for (int z = 0; z < _ar.GetLength(2); z++)
//             {
//                 if (_ar[x, y, z] == _num) return true;
//             }
//         }
//     }
//     return false;
// }

// void Print3Darray(int[,,] _array)
// {
//     for (int x = 0; x < _array.GetLength(0); x++)
//     {
//         for (int y = 0; y < _array.GetLength(1); y++)
//         {
//             for (int z = 0; z < _array.GetLength(2); z++)
//             {
//                 Console.Write($" {_array[x, y, z]} ({x},{y},{z})");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// const int n = 4;
// const int m = 4;

// Print(FillArray(n, m));

// int[,] FillArray(int _n, int _m)
// {
//     int[,] matrix = new int[_n, _m];

//     int row = 0;
//     int col = 0;
//     int dx = 1;
//     int dy = 0;
//     int dirChanges = 0;
//     int visits = _m;

//     for (int i = 0; i < matrix.Length; i++)
//     {
//         matrix[row, col] = i + 1;
//         if (--visits == 0)
//         {
//             visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//             int temp = dx;
//             dx = -dy;
//             dy = temp;
//             dirChanges++;
//         }

//         col += dx;
//         row += dy;
//     }
//     return matrix;
// }

// void Print(int[,] _ar)
// {
//     for (int i = 0; i < _ar.GetLength(0); i++)
//     {
//         for (int z = 0; z < _ar.GetLength(1); z++)
//         {
//             if (_ar[i, z] < 10) Console.Write($"{_ar[i, z] / 10}{_ar[i, z]} ");
//             else
//             {
//                 Console.Write($"{_ar[i, z]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07           */

int[,] array = new int[8, 8];


for (int i = 0, j = 0, t = 0; t < array.Length; t++)
{
    array[i, j] = t + 1;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(string.Format("{0:D2} ", array[i, j]));
    Console.WriteLine();
}
