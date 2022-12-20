/* Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */ 


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