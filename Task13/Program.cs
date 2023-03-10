// 13. Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.Write("Введите число: ");

long input = ReadConsole();

string result = ThirdDigit(input);

Print(result);

string ThirdDigit(long num)
{
    if (num < 100)
    {
        return "третьей цифры нет";
    }
    else
    {
        while (num > 999)
        {
            num /= 10;
        }

        return Convert.ToString(num % 10);
    }
}

long ReadConsole()
{
    return Convert.ToInt64(Console.ReadLine());
}

void Print(string text)
{
    Console.WriteLine(text);
}