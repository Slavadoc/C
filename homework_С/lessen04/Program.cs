// Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A; int B;
Console.Write("Enter number A : ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write("Enter number B : ");
int.TryParse(Console.ReadLine()!, out B);
Console.Write(Вegree(A,B));

int Вegree(int _a, int _b){
    int sum = _a;
    for(int i = 1; i < _b; i++){
        sum = sum * _a;
    }
    return sum;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int a;
// Console.Write("Enter number : ");
// int.TryParse(Console.ReadLine(), out a);

// int length = Length(a);
// Console.Write(Sum(a,length));
// int Length(int _a){
//     int count = 0;
//     while(_a > 0){
//         _a /=10;
//         count++;
//     }
//     return count;
// }

//  int Sum(int _a,int _length){
//     int[] array = new int[_length];
//     int sum = 0;
//     for(int i =0; i < _length; i++){
//         array[i] = _a % 10;
//         _a /=10;
//     }
//     for(int z = 0; z < array.Length; z++){
//         sum +=array[z];
//     }
//     return sum;
// }

// Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// CreateArray();
// void CreateArray(){
//     int[] array = new int[8];
//     for(int i = 0; i < 8; i++){
//         array[i] = new Random().Next(0,20);
//     }
//     Console.Write("[");
//     for(int z =0; z <array.Length; z++){
//         if(z == array.Length -1){
//             Console.Write($"{array[z]}]");
//         } else {
//         Console.Write($"{array[z]}, ");
//         }
//     }
// }