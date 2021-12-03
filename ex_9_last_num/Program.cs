// Показать последнюю цифру трёхзначного числа

Console.Write("Введиет число: ");
int number = int.Parse(Console.ReadLine());



if (number <= 999 && number >= 100)
{
    int last = number % 10;
    Console.WriteLine(last);
}

else
{
    Console.WriteLine("число не трехзначное");
}