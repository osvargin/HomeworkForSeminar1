﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());
int m = numA;
if(m > numB && m > numC)
{
    Console.WriteLine(numA);
}
else if(m < numC)
{
   Console.WriteLine(numC);
}
else
{
    Console.WriteLine(numB);
}