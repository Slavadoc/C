using System.Net.Http.Headers;
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m;
Console.Write(" Введите размер количсество  чисел : ");
int.TryParse(Console.ReadLine()!, out m);
int count = Count(m);
Console.WriteLine($" Введено положительных цифр : {count}");

int Count(int _m)
{
    int count = 0;
    for (int i = 0; i < _m; i++)
    {
        int a;
        Console.Write("Введите число : ");
        int.TryParse(Console.ReadLine()!, out a);
        if (a > 0) count++;
    }
    return count;
}

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// int b1; int k1; int b2; int k2;
// Console.Write("Введите значения  b1 : ");
// int.TryParse(Console.ReadLine()!, out b1);
// Console.Write("Введите значения  k1 : ");
// int.TryParse(Console.ReadLine()!, out k1);
// Console.Write("Введите значения  b2 : ");
// int.TryParse(Console.ReadLine()!, out b2);
// Console.Write("Введите значения  k2 : ");
// int.TryParse(Console.ReadLine()!, out k2);
// double[] dots = FindDot(k1, b1, k2, b2);
// Console.Write($"Точка пеесечения : {dots[0]} {dots[1]} ");

// double[] FindDot(double _k1, double _b1, double _k2, double _b2)
// {
//     double[] _dots = new double[2];
//     _dots[0] = (_b1 - _b2) / (_k2 - _k1); //double x
//     _dots[1] = (_k2 * _b1 - _k1 * _b2) / (_k2 - _k1); //
//     return _dots;
// }

//  void CrossPoint(double k1, double b1, double k2, double b2)
// {
//     double x = (b1 - b2) / (k2 - k1);
//     double y = (k2 * b1 - k1 * b2) / (k2 - k1);
//     if (k1 == k2) Console.Write("Заданные прямые не пересекаются!");
//     else
//         Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
// }
