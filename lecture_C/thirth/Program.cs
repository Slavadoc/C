using System.Reflection.Emit;
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);

void PtintArray(int[] _array) {
    int count = _array.Length;
    for (int i = 0; i < count; i++){
        Console.Write($"{_array[i]} ");
    }
    Console.WriteLine();
}

 // сортировки методом выбора
void SelectionSort(int[] _array){
    for(int i =0; i < _array.Length -1; i++){
        int minPosition = i;
        for(int j = i + 1; j < _array.Length; j ++){
            if( _array[minPosition] > _array[j]) minPosition = j;
        }
        int temp = _array[i];
        _array[i] = _array[minPosition];
        _array[minPosition] = temp;
    }
}

// // Пузырек

// void Sort(int[] _array) {
//     for(int i = 0; i <_array.Length -1; i++){
//         for(int j =0; j < _array.Length -1; j ++) {
//             if( _array[j] > _array[j + 1]){
//                 int temp = _array[j];
//                 _array[j] = _array[j +1];
//                 _array[j +1] = temp;
//             }
//         }
//     }
// }




// int[] array = {1,45,2,6,9,4,3,7};
// int[] newArray = Sort(array);
// Console.WriteLine(newArray);
// printArray(array);

// void Sort(int[] array){
//     for(int i = 0; i <array.Length-1; i++){
//         int minPosition  = i;
//         for(int z = i+1; z <array.Length-1; z++){
//             if(array[z] > array[minPosition]){
//                 minPosition = z;
//             }
//         }
//         int t = array[i];
//         array[i] =array[minPosition];
//         array[minPosition] = t;
//     }
// }

// void printArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($" {array[i]}");
//     }
// }

// //=====Работа с текстом
// // Дан текст. В тексте нужно все пробелы заменить чёрточками,
// // маленькие буквы “к” заменить большими “К”,
// // а большие “С” маленькими “с”. 

// string text = Console.ReadLine();
// //Console.WriteLine(WindOfChange(text));

// string newString_ = changeChar(text, ' ', '-');
// string newStringK = changeChar(newString_, 'к', 'К');
// string newStringC = changeChar(newStringK, 'С', 'с');

// Console.WriteLine(newStringC); 

// string changeChar(string text,char  oldChar,char newChar){
//     string newText = String.Empty;
//     for(int i = 0; i < text.Length; i++) {
//         if( text[i] == oldChar) {
//             newText += newChar;
//         } else {
//             newText += text[i];
//         }
//     }
//     return newText;
// }

// моя версия
// string WindOfChange(string text){
//     string newString = String.Empty;
//     for(int i=0; i < text.Length; i++){
//         if(text[i] == ' '){
//             newString += '-';
//         }else if (text[i] == 'к') {
//             newString += 'К';
//         }else  if (text[i] == 'С') {
//             newString += 'с';
//         }
//         else { 
//             newString = newString + $"{text[i]}";
//         }
//     }
//     return newString;
// }
//  Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде,  вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?

// char[] WindOfChange(string text){
//     char[] end = new char[text.Length];
//     for(int i = 0 ; i < text.Length; i++){
//         if(text[i] == ' '){
//             end[i] = '-';
//         } if (text[i] == 'к') {
//             end[i] = 'К';
//         } if (text[i] == 'С') {
//             end[i] = 'с';
//         }else{
//             end[i] = text[i];
//         }
//     }
//     return end;
// }

// // //Выводим таблицу умножения 
// for(int i =2; i < 10; i++){
//     for( int z = 2; z < 10; z ++){
//         Console.WriteLine($"{i} * {z} = {i * z}");
//     }
//     Console.WriteLine();
// } 

// using System.Data;
// // Группы методов
// Method1();
// Console.Write("Enter message : ");
// string message = Console.ReadLine();
// Console.Write("Enter count : ");
// int count = int.Parse(Console.ReadLine());
// Method2(message,count);
// int year = Method3();
// Console.WriteLine($" Year today is: {year}");
// string strM4 = Method4(message,count);
// Console.WriteLine(strM4);
// // 1 группа 
// void Method1(){
//     Console.WriteLine("Method 1");
// }
// // 2 группа 
// void Method2(string msg, int count){
//     for( int i = 0; i <count; i++){
//         Console.WriteLine($" Message : {msg}");
//     }
// }
// // 3 группа 
// int Method3(){
//     return DateTime.Now.Year;
// }
// // 4 группа 
// string Method4(string message, int count){
//     string result = String.Empty;
//     int i = 0;
//     while( i < count){
//         result = result + message;
//         i++;
//     }
//     return result;
// }