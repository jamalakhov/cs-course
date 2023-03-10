// 12. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет


Console.Clear();
Console.Write("Введите первое число: ");

int firstNumber = ReadConsole();

Console.Write("Введите второе число: ");

int secondNumber = ReadConsole();

bool result = IsEqualSquared(firstNumber, secondNumber);

Print(result ? "да" : "нет");

bool IsEqualSquared(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

int ReadConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

void Print(string text)
{
    Console.WriteLine(text);
}