// 68. Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m, n) = n + 1,                    если m = 0
// A(m, n) = A(m - 1, 1),              если m > 0 и n = 0
// A(m, n) = A(m - 1, A(m, n - 1)),    если m > 0 и n > 0

Console.Clear();

int m = ReadConsole("Введите первое натуральное число: ");
int n = ReadConsole("Введите второе натуральное число: ");

if (!IsNatural(m) || !IsNatural(n))
{
    Console.WriteLine($"Присутствуют не натуральные числа ({m}, {n})");
}
else
{
    int result = Ackermann(m, n);
    Console.WriteLine(result);
}

//////////////////////////////////////////////////////////
bool IsNatural(int num)
{
    return num >= 0;
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int ReadConsole(string message)
{
    string input = String.Empty;
    int result = 0;
    bool isValid = false;

    do
    {
        Console.Write(message);
        try
        {
            input = Console.ReadLine();
            result = Convert.ToInt32(input);
            isValid = true;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Значение {input} невозможно конвертировать в число");
        }

    } while (!isValid);

    return result;
}