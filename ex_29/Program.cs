// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N: ");

int N = int.Parse(Console.ReadLine());
int result = 1;
int start = 1;
while (start <= N)
{
    result = result * start;
    start++;
}
Console.WriteLine(result);