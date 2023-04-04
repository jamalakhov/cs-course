// 65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

int from = ReadConsole("Введите целое число: ");
int to = ReadConsole("Введите целое число: ");

PrintNaturalNumber(from, to);

//////////////////////////////////////////////////////////////
void PrintNaturalNumber(int from, int to)
{
    if (from == to)
    {
        Console.Write($"{to} ");
        return;
    }

    if (from > to)
    {
        Console.Write($"{from} ");
        PrintNaturalNumber(from - 1, to);
    }
    else
    {
        Console.Write($"{from} ");
        PrintNaturalNumber(from + 1, to);
    }
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}