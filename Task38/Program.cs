// 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] arrayDouble = CreateArrayRndDoub(7, 3, 45);

PrintArray(arrayDouble);

double min = GetMin(arrayDouble);
double max = GetMax(arrayDouble);

Console.WriteLine($"\nmin: {min}\nmax: {max}");

double diffDouble = Difference(min, max);

Console.WriteLine($"diff: {diffDouble}");

/////////////////////////////////////////////////////////

double Difference(double min, double max)
{
    double diff = max - min;
    return Math.Round(diff, 1, MidpointRounding.AwayFromZero);
}

double[] CreateArrayRndDoub(int size, int min, int max)
{
    double[] array = new double[size];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        double digit = random.NextDouble() * (max - min) + min;
        array[i] = Math.Round(digit, 1, MidpointRounding.AwayFromZero);
    }

    return array;
}

double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }

    return max;
}

double GetMin(double[] arr)
{
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }

    return min;
}


void PrintArray(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join(" | ", arr));
}