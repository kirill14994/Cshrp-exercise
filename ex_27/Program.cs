﻿// Определить количество цифр в числе
Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());

int count = 0;

while (a != 0)
{
   a = a / 10;
    count++;
}
Console.WriteLine(count);