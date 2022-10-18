using System.Collections.ObjectModel;
int[] array = new int[10];
Console.Write("Enter your number: "); 
int.TryParse(Console.ReadLine(), out int number);
fillArray(array);
printArray(array);
Console.Write($"индекс  = {indexOf(array,number)}");

int indexOf(int[] coll,int number){
    int find = 0; 
    for(int i = 0 ; i < coll.Length; i++) {
        if(coll[i] == number){
            find = i;
            break;
        }
    }
    return find;
}

void fillArray(int[] collection){
    //Console.WriteLine(number);
    for(int i = 0; i < collection.Length; i++){
        //Console.WriteLine(collection[i]);
        collection[i] = new Random().Next(1,10);
    }
}

void printArray(int[] collection){
    int i = 0;
    int length = collection.Length;
    while( i < length){
        Console.WriteLine(collection[i]);
        i++;
    }
}
// Начнём с ключевого слова void. Далее дадим наименование нашему методу. В качестве
// аргумента будет приниматься какая-то коллекция, то есть аргумент collection. Затем нам надо
// получить длину нашего массива. Делается это посредством collection.Length. На следующем
// этапе возьмём позицию index, которая по умолчанию будет начинаться с 0. Теперь в цикле
// while пропишем index < length. В фигурных скобках пропишем index + 1, но такую
// конструкцию принято на языке С# писать более компактно.
// void FillArray(int[] collection)

// // Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
// // некоторым значением, который определяет пользователей.

// int[] Array = {1,2,3,4,9,6,7,9,9,10,11,12,13,14};
// Console.Write("Enter your number : ");
// int number = int.Parse(Console.ReadLine()); 
// int length = Array.Length;
// int i = 0;

// while( i  < length){
//     if(Array[i] == number){
//         Console.WriteLine($"{i}");
//         break;
//     }
//     i++;
// }

// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
// что мы нашли позицию.
// 15
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
// на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. А если этого
// элемента так и нет, надо сообщить об этом.
// int [] firstArray = {1,2,3,4,5,6,7,8,9,10};
// firstArray[0] = 12;

// Console.WriteLine(firstArray[0]);

// // int c1 = 1; int c2 = 2; int c3 = 3;
// // int c4 = 5; int c5 = 232; int c6 = 435;
// // int c7 = -123; int c8 = 0; int c9 = 42;

// int Max(int c1, int c2, int c3){
//     int max = 0;
//     if (c1 > max){
//         max = c1;
//     }if(c2 > max){
//         max = c2;
//     } if (c3 > max){
//         max = c3; 
//     }
//     return max;
// }
// int end = Max(Max(firstArray[0],firstArray[1],firstArray[2]),
//               Max(firstArray[3],firstArray[4],firstArray[5]),
//               Max(firstArray[6],firstArray[7],firstArray[8]));
// Console.Write(end);

// Console.Write("Enter your number : ");
// double a = double.Parse(Console.ReadLine());

// double c = f(a);

// double f(double x){
//     double result = x*x + 1;
//     return result; 
// }

// Console.Write(c);
