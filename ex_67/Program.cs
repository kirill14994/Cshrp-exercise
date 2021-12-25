// Показать натуральные числа от N до 1, N задано


void Numbers(int N, int end)
{
    if (N != end - 1)
    {
        Console.Write($"{N} ");
        Numbers(N - 1, end);
    }
}

Numbers(10, 1);