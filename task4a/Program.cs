// Найти расстояние между точками в пространстве 3D
Console.Write("Введите координату X точки 1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки 1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки 1: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату X точки 2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки 2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки 1: ");
double z2 = double.Parse(Console.ReadLine()!);

double cat1 = x2 - x1;
double cat2 = y2 - y1;
double cat3 = z2 - z1;

double distance = Math.Sqrt(Math.Pow (cat1, 2) + Math.Pow (cat2, 2) + Math.Pow (cat3, 2));

Console.WriteLine("Расстояние равно: " + distance);