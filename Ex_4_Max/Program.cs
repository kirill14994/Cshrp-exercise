// Найти максимальное из трех чисел

Console.Write("Введите число 1: ");

int numA = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");

int numB = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");

int numC = int.Parse(Console.ReadLine());

int max = numA;

if (numA < numB)
{
    max = numB;
}

else
{
    max = numA;
}

if (max < numC)
{
    max = numC;
}

else 
{
    max = numA;
}

Console.Write("Максимальное: ");
Console.Write(max);
