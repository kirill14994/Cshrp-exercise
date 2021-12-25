// Показать натуральные числа от M до N, N и M заданы

int M = 1;
int N = 15;

void Numbers(int end, int start)
{
    if (start != end + 1)
    {
        Console.Write($"{start}  ");
        Numbers(end, start + 1);
    }
}
Numbers(N, M);