// 36. Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] arr = CreateArrayRndInt(7, 5, 15);

PrintArray(arr);

int resulSum = SkipEvenSum(arr);

Console.WriteLine("\n" + resulSum);

int SkipEvenSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}