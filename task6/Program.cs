// Найти сумму чисел от 1 до А
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);

int count = 1;
int summ = 0;

while (count <= a)
{
    summ = summ + count;
    count++;
}
Console.Write("Сумма чисел равна: ");
Console.WriteLine(summ);