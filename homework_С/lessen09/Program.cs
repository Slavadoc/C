// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N;
Console.Write("Введите число : ");
int.TryParse(Console.ReadLine()!, out N);
ShowNumber(N);

void ShowNumber(int _N)
{
    if (_N == 1)
    {
        Console.Write($"{_N}");
    }
    else
    {
        Console.Write($"{_N} ");
        ShowNumber(_N - 1);
    }
}

// int N;
// Console.Write("Введите число : ");
// int.TryParse(Console.ReadLine()!, out N);
// Console.Write(Show(N));
// string Show(int _N)
// {
//     if (_N == 1) return $"1";
//     return $"{_N} {Show(_N - 1)}";
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M, N;
// Console.Write("Введите число M: ");
// int.TryParse(Console.ReadLine()!, out M);
// Console.Write("Введите число N: ");
// int.TryParse(Console.ReadLine()!, out N);
// Console.Write($"-> {SumOfNumber(N, M)}");

// int SumOfNumber(int _N, int _M)
// {
//     if (_N == _M) return _M;
//     return _N += SumOfNumber(_N - 1, _M);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int M, N;
// Console.Write("Введите число M: ");
// int.TryParse(Console.ReadLine()!, out M);
// Console.Write("Введите число N: ");
// int.TryParse(Console.ReadLine()!, out N);
// Console.Write($"-> {recursion(M, N)}");

// int recursion(int m, int n)
// {
//     // Базовый случай
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     // Шаг рекурсии / рекурсивное условие
//     else if (n == 0 && m > 0)
//     {
//         return recursion(m - 1, 1);
//     } // Шаг рекурсии / рекурсивное условие
//     else
//     {
//         return recursion(m - 1, recursion(m, n - 1));
//     }
// }