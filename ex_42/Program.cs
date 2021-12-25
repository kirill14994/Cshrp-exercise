// Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите числа");

int[] array = new int[5];
int len = array.Length;
int count = 0;
for (int i = 0; i < len; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;

    }
}

Console.WriteLine(count);