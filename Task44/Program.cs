// 44. Выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int number = ReadeConsole("Введите число: ");

int[] result = FibonacciRecursive(number);
PrintArray(result);

int[] FibonacciRecursive(int input)
{
    if (input < 1) return new int[0];
    if (input == 1) return new int[] { 0, 1 };

    int[] array = new int[input];
    array[1] = 1;

    for (int i = 0; i < input - 1; i++)
    {
        array[i + 1] = Fibonacci(i);
    }
    return array;
}

int Fibonacci(int num)
{
    if (num == 0 || num == 1) return 1;
    return Fibonacci(num - 1) + Fibonacci(num - 2);
}

void PrintArray(int[] arr)
{
    Console.WriteLine("{0}", string.Join(" ", arr));
    Console.WriteLine();
}

int ReadeConsole(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}