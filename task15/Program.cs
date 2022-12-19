/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите цифру");
int num = int.Parse(Console.ReadLine()!);
if (num == 6 || num == 7)
{
    Console.WriteLine("да, выходной");
}
else if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("нет, не выходной");
}
else 
{
    Console.WriteLine("не верно ввели цифру, проверьте");
}
