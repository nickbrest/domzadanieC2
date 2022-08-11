// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int summ = 0;

while (a > 0)
{
    summ = summ + a % 10;
    a = a / 10;
}

Console.WriteLine("Сумма цифр в числе равна: " + summ);