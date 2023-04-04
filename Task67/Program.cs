// 67. Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int number = ReadConsole("Введите число: ");

int result = SumDigit(number);
Console.WriteLine(result);

///////////////////////////////////////////////////////////
int SumDigit(int num)
{
    return num > 0 ? SumDigit(num / 10) + num % 10 : 0;
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}