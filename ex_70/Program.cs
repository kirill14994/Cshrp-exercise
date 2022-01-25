// Найти сумму цифр числа

int number = -23;

int Sum(int num)
{
    if (num < 0) num *= -1;
    if (num != 0) return num % 10 + Sum(num / 10);
    return 0;
}
Console.WriteLine(Sum(number));


// int SumNumber(int num)
// {
//     if (num > 0) return num % 10 + SumNumber(num / 10);
//     return 0;
// }
// Console.WriteLine(SumNumber(-23));

