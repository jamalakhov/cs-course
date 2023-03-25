// 43. Напишите программу, которая найдёт
// точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int[] dataLine1 = ReadeConsole("Введите данные для линии ", 1);
int[] dataLine2 = ReadeConsole("Введите данные для линии ", 2);

if (ValidateLine(dataLine1, dataLine2))
{
    (double x, double y) = FindInterPoint(dataLine1, dataLine2);

    System.Console.WriteLine($"\n({x}; {y})");
}

///////////////////////////////////////////////////////////////////

(double, double) FindInterPoint(int[] line1, int[] line2)
{
    int b1 = line1[0];
    int k1 = line1[1];
    int b2 = line2[0];
    int k2 = line2[1];

    double x = Convert.ToDouble((b2 - b1)) / Convert.ToDouble((k1 - k2));
    double y = k1 * x + b1;

    return (Math.Round(x, 1), Math.Round(y, 1));
}

int[] ReadeConsole(string message, int lineNumber)
{
    int index = 0;
    int[] lineData = new int[2];
    string[] mess = new string[2] { $"Введите b{lineNumber}: ", $"Введите k{lineNumber}: " };

    Console.WriteLine("\n" + message + lineNumber);

    while (index != 2)
    {
        while (true)
        {
            Console.Write(mess[index]);
            var input = Console.ReadLine();

            if (ValidateData(input))
            {
                int digit = Convert.ToInt32(input);
                lineData[index] = digit;

                index++;
                break;
            }
        }
    }
    return lineData;
}

bool ValidateData(string inputData)
{
    if (inputData != null)
    {
        double number;
        if (double.TryParse(inputData, out number))
        {
            if (Convert.ToInt32(number) == Convert.ToDouble(number))
            {
                return true;
            }
            else
            {
                Console.WriteLine($"\nОшибка: дробное число ({number})\n");
                return false;
            }
        }
        else
        {
            Console.WriteLine($"\nОшибка: значение ({inputData}) не является числом\n");
            return false;
        }
    }
    else
    {
        Console.WriteLine("\nОшибка: пустой ввод\n");
        return false;
    }
}

bool ValidateLine(int[] line1, int[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            Console.WriteLine("\nПрямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("\nПрямые параллельны");
            return false;
        }
    }
    return true;
}