// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа
// 78 -> 8
// 25 -> 5
// 93 -> 9

Console.Clear();

int random = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из [10, 99] -> {random}");

int max = MaxDigit(random);

Console.WriteLine(max);

int MaxDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;

    return digit1 > digit2 ? digit1 : digit2;
}
