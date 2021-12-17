// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N");

double N = double.Parse(Console.ReadLine());

for (double i = 1; i <= N; i++)
{
    Console.WriteLine($"квадрат числа {i} = {Math.Pow(i, 2)}");
}



