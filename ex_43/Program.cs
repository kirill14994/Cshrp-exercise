// Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите число: ");

int a = int.Parse(Console.ReadLine());

void ToBin(int number)
{
    if (number == 0)
    {
        return;
    }

    ToBin(number / 2);
    Console.Write(number % 2);
}
ToBin(a);
