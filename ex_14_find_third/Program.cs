// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введиет число: ");
int number = int.Parse(Console.ReadLine());



if (number > 100)
{
    int last = number % 10;
    Console.WriteLine(last);
}

if (number > 999)
{
    int n = number % 100;
    int third = n / 10;

    Console.WriteLine(third);
}

else
{
    Console.WriteLine("нет");
}
