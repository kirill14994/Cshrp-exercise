// Показать числа от -N до N

Console.Write("Введиет число N: ");
int N = int.Parse(Console.ReadLine());

int minusN = -N;

while (minusN <= N)
{
    Console.WriteLine(minusN);
    minusN = minusN +1;
}