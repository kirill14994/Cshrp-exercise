// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");

int B = int.Parse(Console.ReadLine());

int pow = 1;

for (int i = 1; i <= B; i++)
{
    pow = pow * A;
}
Console.WriteLine(pow);
