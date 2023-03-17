// 29. Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int arrSize = ReadConsole("Введите размер массива: ");

int[] array = CreateArray(arrSize);

PrintArray(array);


int[] CreateArray(int arraySize)
{
    int[] newArray = new int[arraySize];

    Random random = new Random();

    for (int i = 0; i < arraySize; i++)
    {
        newArray[i] = random.Next(0, 10);
    }

    return newArray;
}

void PrintArray(int[] arrayInt)
{
    Console.WriteLine("[{0}]", string.Join(", ", arrayInt));
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

            if (number <= 0) throw new FormatException();

            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Ошибка ввода {input}");
        }
    }
}