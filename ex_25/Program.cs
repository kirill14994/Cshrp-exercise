// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A: ");

int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    sum = sum + i;
    if (i < A)
    {
        Console.Write($"{i}+");
    }
    else
    {
        Console.Write($"{i}=");
    }
}
Console.WriteLine($"{sum}");



// Console.Write("Введи A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = A * (A + 1) / 2;
// Console.Write("Сумма равна: ");
// Console.WriteLine(sum);
