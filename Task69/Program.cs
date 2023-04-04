// 69. Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int number = ReadConsole("Введите число: ");
int pow = ReadConsole("Введите степень: ");

int result = PowerRec(number, pow);
Console.WriteLine(result);

//////////////////////////////////////////////////////////////
int PowerRec(int number, int pow)
{
    return pow == 0 ? 1 : PowerRec(number, pow - 1) * number;
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}