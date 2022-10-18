// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Enter number : ");
// int.TryParse(Console.ReadLine(), out int a);

// int b = (a / 10) % 10 ;
// Console.Write(b);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number : ");
int.TryParse(Console.ReadLine(), out int a);
if( a < 99 ){
    Console.WriteLine("третьей цифры нет");
} else {
    Console.WriteLine($" Третья цифра = {findThirth(a)}");
}

int findThirth(int _a){
    int _b  = 0;
    if( 1000 > _a){
        // Console.WriteLine("1 работает ");
        _b = (_a % 100) % 10;
    }
    if(_a > 999 && _a < 10000){
        //Console.WriteLine($"второй работает a = {_a}");
        _b = ((_a % 1000) % 100) / 10;
    }
    if(_a > 9999){
        //Console.WriteLine($"трктий работает a = {_a}");
        _b = ((_a % 10000) % 1000) / 100;
    }
    return _b;
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня недели от 1 до 7 : ");
// int numberDay;
// int.TryParse(Console.ReadLine(), out numberDay);
// ItisWeekend(numberDay);

// void ItisWeekend(int _numberDay){
//     if( _numberDay == 6 ||  _numberDay == 7 ){
//         Console.WriteLine("да");
//     } else {
//         Console.WriteLine("нет");
//     }
// }