﻿/* Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void ShowNumbers(int number)
{
    if (number < 1) return;
    Console.Write(number + " ");
    ShowNumbers(number - 1);
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
ShowNumbers(N);