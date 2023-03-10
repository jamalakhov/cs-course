// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int random = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число из [100, 999] -> {random}");

int number = Delete2Digit(random);

Console.WriteLine(number);

int Delete2Digit(int number)
{
    int digit1 = number / 100;
    int digit2 = number % 10;

    return digit1 * 10 + digit2;
}
