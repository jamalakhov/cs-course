// 64. Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int from = ReadConsole("Введите натуральное число: ");
int to = 1;

if (IsNaturalNumber(from))
{
    PrintNaturalNumbers(from, to);
}
else
{
    Console.WriteLine($"Число {from} не является натуральным");
}
////////////////////////////////////////////////////////////////
bool IsNaturalNumber(int number)
{
    return number > 0;
}

void PrintNaturalNumbers(int from, int to)
{
    if (from == to)
    {
        Console.Write($"{to} ");
        return;
    }

    PrintNaturalNumbers(from, to + 1);
    Console.Write($"{to} ");
}


int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}