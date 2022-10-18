
int[] array = new int[20];

foreach (var item in CreateArray(20))
    Console.Write($"{item} ");

int[] CreateArray(int _size)
{
    int[] _array = new int[_size];
    for (int i = 0; i < _size; i++)
        _array[i] = new Random().Next(10);
    return _array;
}


// int a = 5;

// Console.WriteLine(a);

// Multiply(ref a);

// Console.WriteLine(a);

// void Multiply(ref int _a)
// {
//     _a *= 2;
// }


// int[] array = new int[20];
// for(int i =0; i <array.Length; i++){
//     array[i] = new Random().Next(10);
// }
// Sort(array);

// for(int i= 0; i <array.Length; i++){
//     Console.Write($" {array[i]}");
// }
// void Sort(int[] _array){
//     for(int j =0; j < _array.Length; j++){
//         for(int i= 0; i<_array.Length-1; i++ ){
//             if(_array[i] > _array[i+1]){
//                 int temp = _array[i];
//                 _array[i] = _array[i+1];
//                 _array[i+1] = temp;
//             }
//         }
//     }  
// }
// int[] array;
// array = CreareArray();

// for(int i =0; i < array.Length; i++){
//     Console.Write($"{array[i]} ");
// }
// int[] CreareArray(){
//     int[] array = new int[8];
//     for(int i =0; i < 8; i++ ){
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }
// // int N;
// Console.Write($"Enter your number : ");
// int.TryParse(Console.ReadLine()!, out N);
// Console.Write($"Произведение чисел  от 1  до {Factorial(N)}");

// int Factorial(int _N){
//     int factirial = 0;
//     for(int i = 1; i <= N; i++) {
//         factirial *= i;
//     }
//     return factirial;
// }

// int G_i = 0;
// string G_str = "";

// Max(5);

// Console.Write($"{G_i} {G_str}");

// void Max(int a)
// {
//     G_i = a;
//     if (a > 0)
//         G_str = "переменная положительна";
//     else if (a < 0)
//         G_str = "переменная отрицательна";
//     else
//         G_str = "переменная равна 0";
//     Min(a);
// }

// void Min(int a)
// {
//     G_i *= -1;
// }


// using System.Security.Principal;
// int G_i = 0;
// string G_str = "";

// Max(5);

// Console.Write($"{G_i} {G_str}");

// void  Max(int _a){
//     G_i = _a ;
//     if(_a > 0) 
//         G_str = "переменная положительная";
//     else if( _a < 0)
//         G_str = "Переменая отрицательная";
//     else 
//         G_str = "пременная равна 0";
// }
// void Min(int _a){
//     G_i = -1;
// }
// struct Test 
// {
//     public int I;
//     public string str;
// }



// int Max(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// double Div(int a, int b)
// {
//     return (double)a / (double)b;
// }

// string Output(string text)
// {
//     return $"+{text}+";
// }

// bool IsEven(int a)
// {
//     if (a % 2 == 0)
//         return true;
//     return false;
// }

// int[] CreateArray(int size)
// {
//     int[] _array = new int[size];
//     return _array;
// }

// void print(string _text)
// {
//     Console.Write(_text);
//     return;
// }

// print($"Это использование функции void");


// // bool isEven(int _a){
// //     if(_a %2 ==0 ){
// //         return true;
// //     }
// //     return false;
// // }

// // int Max(int _a, int _b){
// //     if( _a > _b) 
// //         return _a;
// //     return _b;
// // }

// // int a;
// // int.TryParse(Console.ReadLine()!, out a);
// // Console.Write(Sum(a));


// // int Sum(int _a){
// //     int sum = 0;
// //     for (int i = 0; i <= _a; i++) {
// //         sum += i;
// //     }
// //     return sum;
// // }