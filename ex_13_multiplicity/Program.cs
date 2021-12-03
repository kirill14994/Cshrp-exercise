// Выяснить, кратно ли число заданному, если нет, вывести остаток.


Console.Write("Введиет число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Число которому должно быть кратно: ");
int number2 = int.Parse(Console.ReadLine());

int result = number1 % number2;

if (result == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine(result);
}


