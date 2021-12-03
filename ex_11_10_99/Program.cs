// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(1, 100);
Console.WriteLine(number);

int first = number / 10;
int second = number % 10;

int max = first;

if (first < second)
{
    max = second;
}

else
{
    max = first;
}

Console.WriteLine(max);