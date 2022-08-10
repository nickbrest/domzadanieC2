// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число 1 (возводимое в квадрат): ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num2 == num1 * num1)
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else
{
    Console.WriteLine("Число 2 не является квадратом числа 1");
}