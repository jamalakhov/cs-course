// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();

int number1 = 7;
int number2 = 23;

Console.Write("Введите число: ");

int input = ReadConsole();

bool result = IsMultiplicity(input, number1, number2);

Print(result ? "да" : "нет");

bool IsMultiplicity(int input, int num1, int num2)
{
    return input % num1 == 0 && input % num2 == 0 ? true : false;
}

int ReadConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

void Print(string text)
{
    Console.WriteLine(text);
}