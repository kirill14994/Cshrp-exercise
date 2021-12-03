// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введиет число: ");
int number = int.Parse(Console.ReadLine());



if (number > 100)
{
    int last = number % 10;
    Console.WriteLine(last);
}

else
{
    Console.WriteLine("нет");
}
