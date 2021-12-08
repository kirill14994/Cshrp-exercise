// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите x: ");

int x = int.Parse(Console.ReadLine());

Console.Write("Введите y: ");

int y = int.Parse(Console.ReadLine());

if (x > 0 & y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 & y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 & y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 & y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else
{
    Console.WriteLine("Невозжно определить четверть");
}
