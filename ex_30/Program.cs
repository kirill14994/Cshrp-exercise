// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число: ");

double number = double.Parse(Console.ReadLine());

number = Math.Pow(number, 3);

if (number % 2 == 0)
{
    Console.WriteLine($"последняя цифpа числа {number} чётная");
}
else
{
    Console.WriteLine($"последняя цифpа числа {number} нечётная");
}