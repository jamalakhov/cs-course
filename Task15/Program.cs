// 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите номер дня недели: ");

int input = ReadConsole();

bool weekend = IsWeekend(input);

Console.WriteLine(weekend ? "да" : "нет");

bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}

int ReadConsole()
{
    return Convert.ToInt16(Console.ReadLine());
}