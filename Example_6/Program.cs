﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
Console.WriteLine("Введите число .");
int num1 = int.Parse (Console.ReadLine()!);

if (num1%2 == 0) { 
Console.WriteLine("Четное");
}
else
{
Console.WriteLine("Нечетное");
}
 