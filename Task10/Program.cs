// 10. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();

Console.Write("Введите трёхзначное число: ");

int input = ReadConsole();

int result = SecondNumber(input);

Print(Convert.ToString(result));

int SecondNumber(int num)
{
    return Math.Abs(num / 10 % 10);
}

int ReadConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

void Print(string text)
{
    Console.WriteLine(text);
}