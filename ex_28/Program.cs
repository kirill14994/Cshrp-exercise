// Подсчитать сумму цифр в числе
Console.WriteLine("Ведите число");

int inputNum = int.Parse(Console.ReadLine());
int result = 0;
int temp = 0;
while (inputNum > 0)
{
    temp = inputNum % 10;
    result = result + temp;
    inputNum = inputNum / 10;
}

Console.WriteLine(result);
