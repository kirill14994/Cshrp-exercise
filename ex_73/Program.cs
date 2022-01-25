// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента
// последовательности задаются пользователем


int Fib(int first, int second, int N)
{
    if (N == 1) return first;
    if (N == 2) return second;
    
    return Fib(first, second, N - 1) + Fib(first, second, N - 2);

}

int count = 10;

for (int i = 1; i < count; i++)
{
    Console.WriteLine(Fib(3, 5, i));
}




