// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int len = array.Length;
int result = 0;
int resultNegative = 0;
for (int i = 0; i < len; i++)
{
    array[i] = new Random().Next(-9, 10);
}

for (int i = 0; i < len; i++)
{
    if (array[i] < 0)
    {
        resultNegative = resultNegative + array[i];
    }
    else
    {
        result = result + array[i];

    }
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных = {result}, Сумма отрицательных = {resultNegative}");