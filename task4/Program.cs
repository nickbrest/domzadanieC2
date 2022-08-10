// Найти расстояние между точками в пространстве 2D
Console.Write("Введите координату X точки 1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки 1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату X точки 2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки 2: ");
double y2 = double.Parse(Console.ReadLine()!);

double cat1 = x2 - x1;
double cat2 = y2 - y1;

double distance = Math.Sqrt(cat1 * cat1 + cat2 * cat2);

Console.WriteLine("Расстояние равно: " + distance);