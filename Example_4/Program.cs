//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

Console.WriteLine("Введите число 1.");
int num1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine()!);
 if (num1 > num2 && num1 > num3)
Console.WriteLine("Nubmer Max = " + num1); 
  else if (num2 > num3)
Console.WriteLine("Number Max = " + num2); 
  else
Console.WriteLine("Number Max = " + num3); 
