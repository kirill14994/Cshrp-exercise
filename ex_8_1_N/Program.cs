// Показать четные числа от 1 до N

Console.Write("Введиет число N: ");
int N = int.Parse(Console.ReadLine());

int start = 2;

while (start <= N)
{
    if (start % 2 == 0)
    {
        Console.WriteLine(start);  
    }
    start = start + 2;
    
}
