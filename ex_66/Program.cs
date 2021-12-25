// Показать натуральные числа от 1 до N, N задано




void Numbers (int end, int start)

{
    if (start != end + 1)
    {
        Console.Write($"{start}  ");
        Numbers(end, start + 1);
    }

}

Numbers(10, 1);