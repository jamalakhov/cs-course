// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");

int firstNumber = ReadConsole();

Console.Write("Введите второе число: ");

int secondNumber = ReadConsole();

int result = IsMultiplicity(firstNumber, secondNumber);

Print(result == 0 ? "кратно" : $"не кратно, остаток {result}");

int IsMultiplicity(int num1, int num2)
{
    return num1 % num2;
}

int ReadConsole()
{
    return Convert.ToInt32(Console.ReadLine());
}

void Print(string text)
{
    Console.WriteLine(text);
}

