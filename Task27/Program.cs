// 27. Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int inputNumber = ReadConsole("Введите число: ");
int resultSum = GetSumDigit(inputNumber);

Console.WriteLine(resultSum);

int GetSumDigit(int input)
{
    int sum = 0;

    while (input > 0)
    {
        sum += input % 10;
        input /= 10;
    }

    return sum;
}

int ReadConsole(string message)
{
    while (true)
    {
        Console.Write(message);
        string input = "";
        try
        {
            input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number == 0) throw new FormatException();
            if (number < 0) number *= -1;

            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Ошибка ввода {input}");
        }
    }
}