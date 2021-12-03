// Удалить вторую цифру трёхзначного числа

Console.Write("Введиет число: ");
int number = int.Parse(Console.ReadLine());



if (number <= 999 && number >= 100)
{
    int last = number % 10;
    int first = number / 100;
    int final = first * 10 + last;

    Console.WriteLine(final);
}

else
{
    Console.WriteLine("число не трехзначное");
}
