﻿// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 999);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 & array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"{count} чисел входящих в отрезок (10,99)");