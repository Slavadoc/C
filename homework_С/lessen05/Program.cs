// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
int length, min, max;
Console.Write("Задайте длину массива ");
int.TryParse(Console.ReadLine()!, out length);
// Console.Write(" минимальное ");
// int.TryParse(Console.ReadLine()!, out min);
// Console.Write("максимальное значение ");
// int.TryParse(Console.ReadLine()!, out max);
int[] array = CreateArray(length);
PrintArray(array);
int count = Count(array);
Console.Write($" количество четных чисел : {count}");

int Count(int[] _array)
{
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i] % 2 == 0) count++;
    }
    return count;
}
int[] CreateArray(int _length, int _min = 100, int _max = 1000)
{
    int[] _array = new int[_length];
    for (int i = 0; i < _length; i++)
    {
        _array[i] = new Random().Next(_min, _max);
    }
    return _array;
}

void PrintArray(int[] _arr)
{
    for (int i = 0; i < _arr.Length; i++)
    {
        Console.Write($" {_arr[i]}");
    }
    Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//int[] array = new int[] { 3, 7, 23, 12 };
// int[] array = new int[] { -4, -6, 89, 6 };
// // int length;
// // Console.Write("Введите длину массива :");
// // int.TryParse(Console.ReadLine(), out length);
// // int[] array = CreateArray(length);
// PrintArray(array);
// int sum = Sum(array);
// Console.Write($" Count : {sum}");

// int Sum(int[] _ar)
// {
//     int sum = 0;
//     for (int i = 0; i < _ar.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += _ar[i];
//         }
//     }
//     return sum;
// }
// int[] CreateArray(int _length, int _min = 100, int _max = 1000)
// {
//     int[] _array = new int[_length];
//     for (int i = 0; i < _length; i++)
//     {
//         _array[i] = new Random().Next(_min, _max);
//     }
//     return _array;
// }

// void PrintArray(int[] _arr)
// {
//     for (int i = 0; i < _arr.Length; i++)
//     {
//         Console.Write($" {_arr[i]}");
//     }
//     Console.WriteLine();
// }


// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76
// List<int> list = CreateList();
// PrintArray(list);
// Console.Write($" Разница = {DiffMaxMin(list)} ");

// int DiffMaxMin(List<int> _list)
// {
//     int max = FindMax(_list);
//     int min = FindMin(_list);
//     return max - min;
// }

// int FindMax(List<int> _list)
// {
//     int max = _list[0];
//     for (int i = 0; i < list.Count; i++)
//     {
//         if (max < list[i]) max = list[i];
//     }
//     return max;
// }

// int FindMin(List<int> _list)
// {
//     int min = _list[0];
//     for (int i = 0; i < list.Count; i++)
//     {
//         if (min > list[i]) min = list[i];
//     }
//     return min;
// }

// List<int> CreateList()
// {
//     List<int> list = new List<int>(); // Динамический список
//     int a;
//     Console.Write("Введите цифру не равную 0 : ");
//     int.TryParse(Console.ReadLine()!, out a);
//     list.Add(a);

//     while (a != 0)
//     {
//         Console.Write("Введите цифру не равную 0 : ");
//         int.TryParse(Console.ReadLine()!, out a);
//         if (a == 0) break;
//         list.Add(a);

//     }
//     return list;
// }

// void PrintArray(List<int> _arr)
// {
//     for (int i = 0; i < _arr.Count; i++)
//     {
//         Console.Write($" {_arr[i]}");
//     }
//     Console.WriteLine();
// }