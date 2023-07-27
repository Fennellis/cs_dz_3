void table(int count)
{
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine($"{i, 3} {Math.Pow(i, 3), 6}");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}

table(n);
