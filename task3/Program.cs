﻿// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти декартовой системы координат: ");
int quarta = int.Parse(Console.ReadLine()!);

if (quarta == 1)
{
    Console.WriteLine("Диапазон возможных координат имеет положительные абсциссы и ординаты");
}

if (quarta == 2)
{
    Console.WriteLine("Диапазон возможных координат имеет отрицательные абсциссы и положительные ординаты");
}

if (quarta == 3)
{
    Console.WriteLine("Диапазон возможных координат имеет отрицательные абсциссы и ординаты");
}

if (quarta == 4)
{
    Console.WriteLine("Диапазон возможных координат имеет положительные абсциссы и отрицательные ординаты");
}

// P.S. возможно я не правильно понял условия задачи?