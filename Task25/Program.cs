// 25. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Clear();



int firstNumber = ReadConsole("Введите число: ");
int secondNumber = ReadSecondNumber("Введите степень: ");
int result = PowerUp(firstNumber, secondNumber);

Console.WriteLine(result);


int PowerUp(int originNum, int powerNum)
{
    int subNum = originNum;

    for (int i = 1; i < powerNum; i++)
    {
        subNum *= originNum;
    }

    return subNum;
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

            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Ошибка ввода {input}");
        }
    }
}

int ReadSecondNumber(string message)
{
    while (true)
    {
        int number = ReadConsole(message);
        if (number > 0) return number;

        Console.WriteLine($"Число не натуральное -> {number}");
    }
}