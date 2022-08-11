// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int count = 1;
int mult = 1;

while (count <= n)
{
    mult = mult * count;
    count++;
}
Console.Write("Произведение чисел равно: " + mult);
