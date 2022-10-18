// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Enter first number :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number :");
int b = int.Parse(Console.ReadLine());

if( a > b ){
    Console.Write($"Max is: {a}");
}else{
    Console.Write($"Max is: {b}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Enter first number : ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter second number : ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Enter thirth number : ");
// int с = int.Parse(Console.ReadLine());

// int max = a;
// if( a < b){
//     max = b;
// }if(max < с){
//     max = с;
// }
// Console.Write($"Max is: {max}");


// // Задача 6:  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите цифру : ");
// int a = int.Parse(Console.ReadLine());

// if(a % 2 == 0){
//     Console.WriteLine("Да");
// } else {
//     Console.WriteLine("Нет");
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("Enter number N : ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;

// while(i <= N){
//     if (i % 2 == 0){
//         Console.Write($" {i}");
//     }
//     i++;
// }

