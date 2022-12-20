/* Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */ 

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);    // ввод числа с консоли
int digit = (int)Math.Log10(num)-2;          // метод с логорифм работает до 9-ти значных чисел, включительно               
                                              
 if (digit > 0)
 {
	Console.WriteLine($"третьей цифра числа {num} является {num % (int)Math.Pow(10, digit + 1) / (int)Math.Pow(10, digit) }" );
 }
else
{
	Console.WriteLine( "нет третьей цифры" );
}


/* // Нахождения числа при помощи строки

Console.WriteLine("введите число");
int num =Convert.ToInt32(Console.ReadLine());
if(num > 99)
    {
		Console.WriteLine($"третья цифра числа {num} является {num.ToString()[2]}");
	}
else
    {
		Console.WriteLine("третьего числа нет");
	}
{
	Console.WriteLine($"третья цифра числа {num} является {digit}");
}*/




