Progress admin

// /*          **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
//             и возводит число А в целую степень B с помощью рекурсии.
//             A = 3; B = 5 -> 243 (3⁵)
//             A = 2; B = 3 -> 8           */

// int a, b;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out b);

// Console.Write($"{Pow(a, b)}");

// int Pow (int _a, int _b)
// {
//     if (_b < 1)
//         return 1;
//     return _a * Pow(_a, _b - 1);
// }

// /*          **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//             453 -> 12
//             45 -> 9           */

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);

// Console.Write($"{DigitsSum(a)}");

// int DigitsSum(int a)
// {
//     if (a == 0) return 0;
//     return a % 10 + DigitsSum(a / 10);


/*          **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"           */

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);

// PrintNumbers(1, a);

// void PrintNumbers(int _start, int _end)
// {
//     if (_start != _end)
//     {
//         Console.Write($"{_start}");
//         PrintNumbers(_start + 1, _end);
//     }
//     else
//         Console.Write($"{_end}");
// }


// /*          **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"           */

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);

// PrintNumbers(1, a);

// void PrintNumbers(int _start, int _end)
// {
//     if (_start == _end)
//     {
//         Console.Write($"{_start}");
//         PrintNumbers(_start + 1, _end);
//     }
// }
