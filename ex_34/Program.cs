// Написать программу замену элементов массива на противоположные

int[] array = new int[5];
int len = array.Length;


for (int i = 0; i < len; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]}  ");
}
Console.WriteLine(" ");
for (int i = 0; i < len; i++)
{
    array[i] = -array[i];
    Console.Write($"{array[i]}  ");
}