/* Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */ 

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);    // ввод числа с консоли
 
 int Digit( int num)               // функция нахождения 2-й цифры из 3-х
 {
    int digit=  (num / 10) % 10;                 // нахождение второго числа              
 return digit;
 }

int secondDigit = Digit( num );
Console.WriteLine( $"вторая цифра числа {num} явлется {secondDigit}" );
