// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите число: ");
int[] array = new int[15];
int len = array.Length;
int find = int.Parse(Console.ReadLine());

for (int i = 0; i < len; i++)
{
    array[i] = new Random().Next(0, 5);
    Console.Write($"{array[i]}  ");
}

bool check = true;
for (int i = 0; i < len; i++)
{
    if (find == array[i])
    {
        check = false;
        Console.WriteLine("В массиве присутсвует заданное число ");
        break;
    }

}
if (check)
{
    Console.WriteLine("В массиве не присутсвует заданное число ");
}