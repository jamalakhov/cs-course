// 66. Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int from = ReadConsole("Введите первое натуральное число: ");
int to = ReadConsole("Введите второе натуральное число: ");

if (!IsNatural(from) || !IsNatural(to))
{
    Console.WriteLine($"Отрезок [{from}, {to}] содержит ненатуральные числа");
}
else
{
    int resultSum = CalculateNaturalSumInRange(from, to);
    Console.WriteLine(resultSum);
}
//////////////////////////////////////////////////////
bool IsNatural(int num)
{
    return num > 0;
}

int CalculateNaturalSumInRange(int from, int to)
{
    if (from == to) return to;

    return from < to
                    ? CalculateNaturalSumInRange(from + 1, to) + from
                    : CalculateNaturalSumInRange(from - 1, to) + from;
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}