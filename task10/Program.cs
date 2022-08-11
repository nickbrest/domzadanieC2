// Показать кубы чисел, заканчивающихся на четную цифру
int n = 25;
int index = 1;

while (index <= n)
{
    int coub = index * index * index;
    if ((coub % 10) % 2 == 0)
    Console.Write(coub + " ");
    index++;
}