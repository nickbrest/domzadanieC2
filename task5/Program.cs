// Найти кубы чисел от 1 до N
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int count = 1;

while (count <= n)
{
    int coub = count * count * count;
    // int coub = Convert.ToInt32(Math.Pow (count, 3));
    Console.Write(coub + " ");
    count++;
}