using System.Diagnostics;
// //"editor.acceptSuggestionOnCommitCharacter": false,
// //  выполнить   %appdata%  -> Code  ->  User  ->  Setting.JSON  

//программа по заданному номеру честври дает возможный 
//диапазон возможных координат точек в этой четверти ( х и у)

int a =0;
Console.Write("Введите координаты четверти : ");
int.TryParse(Console.ReadLine()!, out a);

switch(a){
    case 1:
        Console.Write("X > 0 Y > 0"); 
        break;
    case 2:
        Console.Write("X > 0 Y < 0");
        break;
    case 3:
        Console.Write("X < 0  Y < 0"); 
        break;
    case 4:
        Console.Write("X < 0  Y > 0 ");
        break;
    default:
          Console.Write("Неверный ввод числа");
          break;  
}

// if(a == 0)
//     Console.Write("Неверный ввод числа");
// if(a == 1)
//     Console.Write("X > 0 Y > 0"); 
// if(a == 2)
//     Console.Write("X > 0 Y < 0");
// if(a == 3) 
//     Console.Write("X < 0  Y < 0"); 
// if(a == 4)
//     Console.Write("X < 0  Y > 0 ");


// int[] A = new int[2];
// int[] B = new int[2];
// Console.Write($"Введите координату X: ");
// int.TryParse(Console.ReadLine()!, out A[0]);
// Console.Write($"Введите координату Y: ");
// int.TryParse(Console.ReadLine()!, out A[1]);

// Console.Write($"Введите координату X2: ");
// int.TryParse(Console.ReadLine()!, out B[0]);
// Console.Write($"Введите координату Y2: ");
// int.TryParse(Console.ReadLine()!, out B[1]);

// double c = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]));
// c = Math.Round(c, 3);
// Console.Write($"Длина отрезка : {c}\n");
// Console.Write("Длина отрезка : {0:N2}", c ); // огранияение переменных до 2 знаках

//String.Format() - тип форматирования 
// мое решение !!!
// Console.WriteLine($"Длина отрезка : {Length(A,B)}");
// //тeорема пифагора.....
// double Length(int[] _A, int[] _B){
//     double lengthC = 0;
//     int lengthA = LengthA(_A,_B);  
//     // Console.WriteLine(lengthA);
//     int lengthB = LengthB(_A,_B);
//     // Console.WriteLine(lengthB); 
//     lengthC = Math.Sqrt(lengthA + lengthB); 
//     return lengthC;
// }

// int LengthA(int[] _A, int[] _B){
//     int length = 0;
//     int a = _A[0]; 
//     int b = _B[0];
//     int max = a;
//     int min = b;
//     if(a > 0 && b > 0 ){  
//         if( max < b ){
//             max = b;
//             min = a;
//         }
//         length = max - min;
//     }else if (a < 0 && b <0){
//         max = a * (-1);
//         min = b * (-1);
//         if( max < b *(-1)){
//             max = b * (-1);
//             min = a * (-1);
//         }
//         length = max - min;
//     }else if((max < 0 && min > 0 )|| (min < 0 && max >0)){
//         if(max < 0){
//             max = max * (-1);
//         }else{
//             min = min * (-1);
//         }
//         length = max + min;
//     }else {
//         length = max - min;
//     } 
//     if(length > 0){
//         return length;
//     }
//     return length * (-1);
// }

// int LengthB(int[] _A, int[] _B){
//    int length = 0;
//     int a = _A[1]; 
//     int b = _B[1];
//     int max = a;
//     int min = b;
//     if(a > 0 && b > 0 ){  // 1 квадрат 
//         if( max < b ){
//             max = b;
//             min = a;
//         }
//         length = max - min;
//     }else if (a < 0 && b <0){ // 3 квадрат 
//         max = a * (-1);
//         min = b * (-1);
//         if( max < b * (-1)){
//             max = b * (-1);
//             min = a * (-1);
//         }
//         length = max - min;
//     }else if((max < 0 && min > 0) || (min < 0 && max >0)){ // 2-4 квадрата
//         if(max < 0){
//             max = max * (-1);
//         }else{
//             min = min * (-1);
//         }
//         length = max + min;
//     }else {
//         length = max - min;
//     }if(length > 0){
//         return length;
//     }
//     return length * (-1);
// }

// // от препода 
// int x = 0, y = 0;
// Console.Write($"Введите координату X: ");
// int.TryParse(Console.ReadLine()!, out x);
// Console.Write($"Введите координату Y: ");
// int.TryParse(Console.ReadLine()!, out y);

// if (x > 0)
// {
// if (y > 0)
// Console.Write($"Плоскость 1");
// else if (y < 0)
// Console.Write($"Плоскость 4");
// }
// else
// {
// if (y > 0)
// Console.Write($"Плоскость 2");
// else if (y < 0)
// Console.Write($"Плоскость 3");
// }

// if (x == 0 && y == 0)
// Console.Write($"Точка лежит на начале координат");
// else if (y == 0)
// Console.Write("Точка лежит на оси X");
// else
// Console.Write("Точка лежит на оси Y");

// сам
// int x = 0;
// int y = 0;

// Console.Write("Ввeдите Х : ");
// int.TryParse(Console.ReadLine()!, out x);
// Console.Write("Введите Y : ");
// int.TryParse(Console.ReadLine()!, out y);

// if(x > 0) {
//     if(y > 0){
//         Console.Write(" Плоскость 1 ");
//     } else if(y < 0){
//         Console.Write(" Плоскость 4 "); 
//     }
//     else {
//         Console.Write("Точка лежит на оси Y");
//     }
    
// } else {
//     if(x < 0){
//         Console.Write("Точка лежит на оси Y");
//     }
//     if(y < 0) {
//     Console.Write(" Плоскость 3 ");
//     }else if(y > 0){
//     Console.Write(" Плоскость 2 ");
//     } if( x == 0){
//     if( y == 0){
//         Console.Write("Точка лежит в начале координат");
//     }else {
//          Console.Write("Точка лежит на оси X");
//     }
//     } 
// }
