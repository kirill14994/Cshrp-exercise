// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];
int count = 0;
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        countEven++;
    }
    else
    {
        count++;
    }
}
Console.WriteLine($"чётныx {countEven}, нечётных {count}");