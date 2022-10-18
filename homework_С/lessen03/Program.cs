//using Internal;
//using System;
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Enter your number : ");
// int.TryParse(Console.ReadLine(), out int n);
// int[] arr = Array(n);
// Print(arr);
// bool isPoli = IsItPalindrome(arr);

// if(isPoli){
//     Console.WriteLine(" Да");
// } else {
//     Console.WriteLine(" Нет");
// }


// int[] Array(int _n){
//     int[] _array = new int[5];
//     //Console.Write(_array.Length);
//     for (int i = _array.Length-1; i >= 0; i--) {
//         _array[i] = _n % 10;
//         //Console.WriteLine();
//          _n /= 10;
//     }
//     return _array;
// }    

// bool IsItPalindrome(int[] _arr){
//     int count = 0;
//     int length = 2;
//     bool IsIt = false;
//     // if( _arr.Length % 2 == 0) {
//     //     length = _arr.Length / 2;
//     //     } else {
//     //     length = _arr.Length / 2 - 1;
//     //     } 
//     for(int i = 0, j = _arr.Length-1; i < length; i++,j-- ){
//         if( _arr[i] == _arr[j]) {
//             count +=1;
//         }
//     }
//     if(count == length) {
//         return IsIt = true;
//     } else {
//         return IsIt = false;
//     }
// }

// void Print(int[] _ar){
//     for( int i= 0; i < _ar.Length; i++) {
//         Console.Write($" {_ar[i]}");
//     }
//     Console.WriteLine();
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int[] A = new int[3];
int[] B = new int[3];
Console.Write("Введите X1 : ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write("Введите Y1 : ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write("Введите Z1 : ");
int.TryParse(Console.ReadLine()!, out A[2]);

Console.Write("Введите X2 : ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write("Введите Y2 : ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write("Введите Z2 : ");
int.TryParse(Console.ReadLine()!, out B[2]);

double d = Math.Sqrt(((A[0] - B[0]) * (A[0] - B[0])) +  ((A[1] - B[1]) * (A[1] - B[1])) + ((A[2] - B[2]) * (A[2] - B[2])));
Console.Write($" Растояние между 2 точками в трехменром пространстве : {d}");
//d= корень (x2-x1) + (y2 - y1) + (z2 - z1)

// Задача 23

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.Write("Enter number n : ");
// int.TryParse(Console.ReadLine(), out int n);
// Cube(n);

// void Cube(int _n) {
//     for(int i = 1; i <=_n; i++) { 
//         if(i == 1){
//             Console.Write($"{i * i * i}");
//         } else {
//             Console.Write($", {i * i * i}");
//         }
//     };
// }