/* Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */ 

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);    // ввод числа с консоли
 
 int GetMaxDigit( int number)               // функция нахождения 2-й цифры из 3-х
 {
    int digit1 = num % 10;                 // нахождение 3-го числа (остаток от деления)  123 -- 3
    int digit2 = num / 10;                 // нахождение первое двойное сисло из          123 -- 12
    int digit3 = digit2 % 10;              // нахождение второго числа                    123 -- 2

 return digit3;
 }

int secondDigit = GetMaxDigit( num);
Console.WriteLine( $"вторая цифра числа {num} явлется {secondDigit}" );
