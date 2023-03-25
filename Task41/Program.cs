// 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3
Console.Clear();

int numb = 5;

double[] myArr = ReadConsole($"Введите {numb} чисел", numb);

int countResult = CountDigit(myArr);

Console.WriteLine(countResult);

//////////////////////////////////////////////////////////////

int CountDigit(double[] arrNumb)
{
    int count = 0;
    for (int i = 0; i < arrNumb.Length; i++)
    {
        if (arrNumb[i] > 0)
        {
            count++;
        }
    }
    return count;
}

double[] ReadConsole(string message, int countNumber)
{
    Console.WriteLine(message + "\n");

    int nextNumber = countNumber - countNumber + 1;

    double[] arrayNumber = new double[countNumber];

    while (countNumber > 0)
    {
        while (true)
        {
            Console.Write($"Введите {nextNumber} число: ");

            var input = Console.ReadLine();
            if (input != null)
            {
                double number;
                if (double.TryParse(input, out number))
                {
                    arrayNumber[nextNumber - 1] = number;
                    nextNumber++;
                    break;
                }
                else
                {
                    Console.WriteLine($"Ошибка: значение ({input}) не является числом");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: пустой ввод");
            }
        }
        countNumber--;
    }
    return arrayNumber;
}