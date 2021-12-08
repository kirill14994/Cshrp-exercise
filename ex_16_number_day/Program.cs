// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели: ");

int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день"); 
}