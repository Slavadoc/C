//кратность числа на 7 и  23
// int a = new Random().Next(7,300);
// Console.WriteLine($"a");
Console.Write("Enter your number : ");
int a = int.Parse(Console.ReadLine());

// if( a % 7 ==0 && a % 23 ==0){
//         Console.Write("Кратно");
// }  else {
//     Console.Write("Не кратно");
// }

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// if( a % b == 0){
//     Console.WriteLine("Кратно ");
// } else {
//     Console.WriteLine($" остаток { a % b }");
//     Console.WriteLine($" остаток { a % b }");
// }
// *Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру 
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98*/

// int rand = new Random().Next(10, 100);

// Console.WriteLine(rand);

// Console.Write($"{rand / 100 * 10 + rand % 10}");
// int rand = new Random().Next(100, 1000);
// Console.Write(rand);
// int a = rand - (rand / 100);
// //int b = rand % 10;

// if ( a > b){
//     Console.Write(a);
// } else {
//     Console.Write(b);
// }
// for (int i =0; i < 30; i++) {
//     int number = new Random().Next(10,100);// % 10 * 2; // четные значения

//     Console.WriteLine(number);
// }
//перегрузки Max(arg1) Max(arg1,arg2)
// Пузырьки 
int[] array = { 4, 9, 3, 7, 2, 9, 2, 5 };
int[] array2 = { 4, 2, 3, 2, 2, 9, -5, 5 };

for (int i = 0; i < array2.Length; i++)
    Console.Write($"{array2[i]} ");

Sort(array2);
Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
    Console.Write($"{array2[i]} ");

void Sort(int[] _array){
    for(int i =0; i <_array.Length -1; i++){
        for(int j =0; j <_array.Length -1; j++) {
            if(_array[j] > _array[j + 1]){
                int temp = _array[j];
                _array[j] = _array[j + 1];
                _array[j + 1] = temp;
            }
        }
    }
}