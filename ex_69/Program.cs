// Найти сумму элементов от M до N, N и M заданы

int M = 1;
int N = 5;

int Sum(int start, int end)
{
    if (start > end)
    {
        return Sum(end, start);
                                // int temp = start;
                                // start = end;
                                // end = temp;
    }

    if (start != end)
    {
        return start + Sum(start + 1, end);
    }
                                // if (start > end)
                                // {
                                //     return start + Sum(start - 1, end);
                                // }
    else return end;
}

Console.WriteLine(Sum(N, M));