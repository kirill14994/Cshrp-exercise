// Показать вторую цифру трёхзначного числа

Console.Write("Введиет число: ");
int number = int.Parse(Console.ReadLine());



if (number <= 999 && number >= 100)
{
    int last = number % 100;
    int second = last / 10;

    Console.WriteLine(second);
}

else
{
    Console.WriteLine("число не трехзначное");
}