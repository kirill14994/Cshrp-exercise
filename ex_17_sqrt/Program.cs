// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число 1: ");

int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");

int secondNumber = int.Parse(Console.ReadLine());

if (Math.Pow(secondNumber, 2) == firstNumber) 
{
    Console.WriteLine($"Число {firstNumber} квадрат числа {secondNumber}");
}
else if (Math.Pow(firstNumber, 2) == secondNumber) 
{
    Console.WriteLine($"Число {secondNumber} квадрат числа {firstNumber}");
}

else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}