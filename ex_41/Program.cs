// Выяснить являются ли три числа сторонами треугольника

double a = new Random().Next(0, 10);
double b = new Random().Next(0, 10);
double c = new Random().Next(0, 10);

Console.WriteLine($"Число 1: {a} Число 2: {b} Число 3: {c}");

if (a + b > c & a + c > b & b + c > a)
{
    Console.WriteLine("Числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Числа не являются сторонами треугольника");
}