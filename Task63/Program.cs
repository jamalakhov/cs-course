// 63. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int number = ReadConsole("Введите целое положительное число: ");
PrintNaturalNumber(number);

//////////////////////////////////////////////////////////////
void PrintNaturalNumber(int number)
{
    if (number > 0)
    {
        PrintNaturalNumber(number - 1);
        Console.Write(number + " ");
    }
}

int ReadConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}