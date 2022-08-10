// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели: ");
int numday = int.Parse(Console.ReadLine()!);

int [] workday = {1, 2, 3, 4, 5};
int [] holiday = {6, 7};

if (holiday.Contains (numday))
{
Console.WriteLine("Это выходной день недели");
}
else 
{
    if (workday.Contains (numday))
    {
    Console.WriteLine("Это рабочий день недели");
    }
    else Console.WriteLine("Error, formatting C: start");
}